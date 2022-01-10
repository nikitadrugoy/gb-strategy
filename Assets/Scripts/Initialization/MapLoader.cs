using System.Collections.Generic;
using Config.Data;
using Config.Map;
using Core.Buildings.Models;
using Core.Buildings.Presenters;
using Core.Buildings.Views;
using Core.General.Models;
using Core.Units.Models;
using Core.Units.Presenters;
using Core.Units.Views;
using UnityEngine;

namespace Initialization
{
    public class MapLoader
    {
        private readonly MainConfig _mainConfig;
        private readonly MapConfig _mapConfig;
        private readonly Transform _buildingRoot;
        private readonly Transform _unitRoot;

        private List<BuildingPresenter> _buildings;
        private List<UnitPresenter> _units;

        public MapLoader(MainConfig mainConfig, MapConfig mapConfig, Transform buildingRoot, Transform unitRoot)
        {
            _mainConfig = mainConfig;
            _mapConfig = mapConfig;
            _buildingRoot = buildingRoot;
            _unitRoot = unitRoot;

            _buildings = new List<BuildingPresenter>(_mapConfig.Buildings.Count);
            _units = new List<UnitPresenter>(_mapConfig.Units.Count);
        }

        public void Load()
        {
            // TODO refactor to generic types and one useful method for different objects (no duplicate)
            LoadBuildings();
            LoadUnits();
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
                    buildingConfig.AssetConfigItem.Prefab,
                    _buildingRoot
                );

                buildingGameObject.position = mapBuildingData.Position;

                var buildingView = buildingGameObject.GetComponent<BuildingView>();
                var presenter = new BuildingPresenter(building, buildingView);
                
                _buildings.Add(presenter);
            }
        }

        private void LoadUnits()
        {
            foreach (MapUnitData mapUnitData in _mapConfig.Units)
            {
                UnitData unitConfig = _mainConfig.Units[mapUnitData.Id];

                var health = new Health(unitConfig.Health);
                var unit = new Unit(health);

                // TODO move to the factory
                Transform unitGameObject = Object.Instantiate(
                    unitConfig.AssetConfigItem.Prefab,
                    _unitRoot
                );

                unitGameObject.position = mapUnitData.Position;

                var unitView = unitGameObject.GetComponent<UnitView>();
                var presenter = new UnitPresenter(unit, unitView);
                
                _units.Add(presenter);
            }
        }
    }
}