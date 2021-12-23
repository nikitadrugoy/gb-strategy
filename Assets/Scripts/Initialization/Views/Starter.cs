using System;
using Config.Assets;
using UnityEngine;

namespace Initialization.Views
{
    public class Starter : MonoBehaviour
    {
        [Header("Configuration")] 
        [SerializeField] private AssetConfig _assetConfig;
        [SerializeField] private TextAsset _mainConfigFile;
        [SerializeField] private TextAsset _mapConfigFile;
        
        [Header("Roots")] 
        [SerializeField] private Transform _buildingRoot;

        private Initializer _initializer;

        private void Awake()
        {
            _initializer = new Initializer();
            _initializer.Init(_assetConfig, _mainConfigFile.text, _mapConfigFile.text, _buildingRoot);
        }

        private void Update()
        {
            _initializer.Update(Time.deltaTime);
        }
    }
}