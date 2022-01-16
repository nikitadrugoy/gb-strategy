using Core.Abstractions;
using UnityEngine;

namespace Core.Units.Commands
{
    public class AttackCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log("Attack");
        }
    }
}