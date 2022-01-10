using System.Collections.Generic;
using Config;
using Config.Assets;
using Config.Map;
using Config.Data;
using GameLoop.Abstractions;
using UnityEngine;
using UserControl;
using Utils.Serialization;

namespace Initialization
{
    public class Initializer : IUpdatable
    {
        private List<IUpdatable> _updatableObjects = new List<IUpdatable>();

        public void Init(AssetConfig assetConfig, string mainConfigJson, string mapConfigJson, Transform buildingRoot,
            Transform unitRoot)
        {
            var deserializer = new JsonSerializer();
            var configLoader = new ConfigLoader(deserializer);
            
            MainConfig mainConfig = configLoader.LoadMainConfig(assetConfig, mainConfigJson);
            MapConfig mapConfig = configLoader.LoadMapConfig(mapConfigJson);

            LoadMap(mainConfig, mapConfig, buildingRoot, unitRoot);
            InitUserControl();
        }

        // TODO move game loop to specific class
        public void Update(float deltaTime)
        {
            foreach (IUpdatable updatableObject in _updatableObjects)
            {
                updatableObject.Update(deltaTime);
            }
        }

        private void LoadMap(MainConfig mainConfig, MapConfig mapConfig, Transform buildingRoot, Transform unitRoot)
        {
            var mapLoader = new MapLoader(mainConfig, mapConfig, buildingRoot, unitRoot);
            
            mapLoader.Load();
        }

        private void InitUserControl()
        {
            var selectedObject = new SelectedObject();
            var userInput = new UserInput(Camera.main, selectedObject);
            
            _updatableObjects.Add(userInput);
        }
    }
}