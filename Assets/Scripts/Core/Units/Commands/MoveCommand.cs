using Core.Abstractions;
using UnityEngine;

namespace Core.Units.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log("Move");
        }
    }
}