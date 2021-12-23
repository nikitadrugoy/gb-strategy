using Core.Buildings.Models;
using Core.Buildings.Views;

namespace Core.Buildings.Presenters
{
    public class BuildingPresenter
    {
        private readonly Building _building;
        private readonly BuildingView _buildingView;

        public BuildingPresenter(Building building, BuildingView buildingView)
        {
            _building = building;
            _buildingView = buildingView;
        }
    }
}