using System;

namespace Core.General.Models.Interfaces
{
    public interface IHealth
    {
        int Value { get; }
        bool IsDead { get; }
    }
}