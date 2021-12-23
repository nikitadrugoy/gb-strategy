using Core.General.Models.Interfaces;

namespace Core.Buildings.Models
{
    // TODO make abstractions
    
    public class Building
    {
        private IHealth _health;

        public Building(IHealth health)
        {
            _health = health;
        }
    }
}