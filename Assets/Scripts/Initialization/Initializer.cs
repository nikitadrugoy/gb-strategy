using System.Collections.Generic;
using Abstractions.GameLoop;
using Config;
using Config.Assets;
using Config.Map;
using Config.Data;
using Core.Buildings.Presenters;
using UnityEngine;
using UserControl;
using Utils.Serialization;

namespace Initialization
{
    public class Initializer : IUpdatable
    {
        private List<IUpdatable> _updatableObjects = new List<IUpdatable>();

        public void Init(AssetConfig assetConfig, string mainConfigJson, string mapConfigJson, Transform buildingRoot)
        {
            var deserializer = new JsonSerializer();
            var configLoader = new ConfigLoader(deserializer);
            
            MainConfig mainConfig = configLoader.LoadMainConfig(assetConfig, mainConfigJson);
            MapConfig mapConfig = configLoader.LoadMapConfig(mapConfigJson);

            LoadMap(mainConfig, mapConfig, buildingRoot);
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

        private void LoadMap(MainConfig mainConfig, MapConfig mapConfig, Transform buildingRoot)
        {
            var mapLoader = new MapLoader(mainConfig, mapConfig, buildingRoot);
            
            mapLoader.Load();
        }

        private void InitUserControl()
        {
            var userInput = new UserInput(Camera.main);
            
            _updatableObjects.Add(userInput);
        }
    }
}