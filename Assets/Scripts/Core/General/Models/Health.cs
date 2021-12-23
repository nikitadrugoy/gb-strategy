using Core.General.Models.Interfaces;

namespace Core.General.Models
{
    public class Health : IHealth
    {
        private int _value;

        public int Value => _value;
        public bool IsDead => _value == 0;

        public Health(int value)
        {
            _value = value;
        }
    }
}