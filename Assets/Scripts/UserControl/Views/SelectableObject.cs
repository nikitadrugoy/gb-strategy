using System;
using UnityEngine;
using UserControl.Abstractions;

namespace UserControl.Views
{
    [RequireComponent(typeof(OutlineSetter))]
    public class SelectableObject : MonoBehaviour, ISelectable
    {
        public event Action Selected;
        public event Action Unselected;

        private OutlineSetter _outlineSetter;

        private void Awake()
        {
            _outlineSetter = GetComponent<OutlineSetter>();
        }

        public void Select()
        {
            _outlineSetter.Select();
            
            Selected?.Invoke();
        }

        public void Unselect()
        {
            _outlineSetter.Unselect();
            
            Unselected?.Invoke();
        }
    }
}