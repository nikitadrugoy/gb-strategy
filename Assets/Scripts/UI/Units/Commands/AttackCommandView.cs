using UI.Commands.Abstractions;
using UnityEngine;

namespace UI.Units.Commands
{
    public class AttackCommandView : CommandButtonView
    {
        protected override void Execute()
        {
            Debug.Log("Attack");
        }
    }
}