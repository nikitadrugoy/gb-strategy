using System;
using UI.Commands.Abstractions;
using UnityEngine;

namespace UI.Commands.Views
{
    public class CommandPanelView : MonoBehaviour
    {
        private CommandButtonView[] _buttons;
        
        private void Awake()
        {
            _buttons = GetComponentsInChildren<CommandButtonView>();
        }
    }
}