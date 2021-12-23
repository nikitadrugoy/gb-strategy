using System;
using Abstractions.Core;
using Core.General.Views;
using UnityEngine;

namespace Core.Buildings.Views
{
    [RequireComponent(typeof(OutlineSetter))]
    public class BuildingView : MonoBehaviour, ISelectable
    {
        public event Action Selected;

        private OutlineSetter _outlineSetter;
        
        // TODO move to model?
        private bool _isSelected;

        private void Awake()
        {
            _outlineSetter = GetComponent<OutlineSetter>();
        }

        public void Select()
        {
            Selected?.Invoke();

            if (_isSelected)
                _outlineSetter.Select();
            else
                _outlineSetter.Unselect();

            _isSelected = _isSelected == false;
        }
    }
}