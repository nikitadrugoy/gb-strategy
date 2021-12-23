using System.Collections.Generic;
using Config.Data;
using Config.Map;
using Core.Buildings.Models;
using Core.Buildings.Presenters;
using Core.Buildings.Views;
using Core.General.Models;
using UnityEngine;

namespace Initialization
{
    public class MapLoader
    {
        private readonly MainConfig _mainConfig;
        private readonly MapConfig _mapConfig;
        private readonly Transform _buildingRoot;

        private List<BuildingPresenter> _buildings = new List<BuildingPresenter>();

        public MapLoader(MainConfig mainConfig, MapConfig mapConfig, Transform buildingRoot)
        {
            _mainConfig = mainConfig;
            _mapConfig = mapConfig;
            _buildingRoot = buildingRoot;
        }

        public void Load()
        {
            LoadBuildings();
        }

        private void LoadBuildings()
        {
            foreach (MapBuildingData mapBuildingData in _mapConfig.Buildings)
            {
                BuildingData buildingConfig = _mainConfig.Buildings[mapBuildingData.Id];

                var health = new Health(buildingConfig.Health);
                var building = new Building(health);

                // TODO move to the factory
                Transform buildingGameObject = Object.Instantiate(
                    buildingConfig.AssetConfig.Prefab,
                    _buildingRoot
                );

                buildingGameObject.position = mapBuildingData.Position;

                var buildingView = buildingGameObject.GetComponent<BuildingView>();
                var presenter = new BuildingPresenter(building, buildingView);
                
                _buildings.Add(presenter);
            }
        }
    }
}