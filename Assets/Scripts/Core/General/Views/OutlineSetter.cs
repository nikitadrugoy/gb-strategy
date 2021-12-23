using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Core.General.Views
{
    public class OutlineSetter : MonoBehaviour
    {
        [SerializeField] private Material _outlineMaterial;

        private Renderer[] _renderers;
        private bool _isSelected;

        private void Awake()
        {
            _renderers = GetComponentsInChildren<Renderer>();
        }

        public void Select()
        {
            if (_isSelected)
                return;

            foreach (Renderer currentRenderer in _renderers)
            {
                List<Material> materials = currentRenderer.materials.ToList();
                
                materials.Add(_outlineMaterial);

                currentRenderer.materials = materials.ToArray();
            }

            _isSelected = true;
            
            Debug.Log(_isSelected);
        }

        public void Unselect()
        {
            if (_isSelected == false)
                return;
            
            foreach (Renderer currentRenderer in _renderers)
            {
                List<Material> materials = currentRenderer.materials.ToList();
                
                materials.RemoveAt(materials.Count - 1);

                currentRenderer.materials = materials.ToArray();
            }

            _isSelected = false;
            
            Debug.Log(_isSelected);
        }
    }
}