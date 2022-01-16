using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Commands.Abstractions
{
    public abstract class CommandButtonView : MonoBehaviour, IDisposable
    {
        [SerializeField] private Button _button;

        private void Awake()
        {
            _button.onClick.AddListener(Execute);
        }

        public void Dispose()
        {
            _button.onClick.RemoveListener(Execute);
        }

        protected abstract void Execute();
    }
}