using Core.General.Models.Interfaces;

namespace Core.Units.Models
{
    // TODO make abstractions
    
    public class Unit
    {
        private IHealth _health;

        public Unit(IHealth health)
        {
            _health = health;
        }
    }
}