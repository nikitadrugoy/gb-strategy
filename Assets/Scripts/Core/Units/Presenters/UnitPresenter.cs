using Core.Units.Models;
using Core.Units.Views;

namespace Core.Units.Presenters
{
    public class UnitPresenter
    {
        private readonly Unit _unit;
        private readonly UnitView _unitView;

        public UnitPresenter(Unit unit, UnitView unitView)
        {
            _unit = unit;
            _unitView = unitView;
        }
    }
}