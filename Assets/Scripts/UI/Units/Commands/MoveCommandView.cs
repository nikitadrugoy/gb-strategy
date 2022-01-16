using UI.Commands.Abstractions;
using UnityEngine;

namespace UI.Units.Commands
{
    public class MoveCommandView : CommandButtonView
    {
        protected override void Execute()
        {
            Debug.Log("Move");
        }
    }
}