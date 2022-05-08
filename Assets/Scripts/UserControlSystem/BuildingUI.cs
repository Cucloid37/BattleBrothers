using System;
using Abstractions;
using UnityEngine;
using UnityEngine.UI;

namespace UserControlSystem
{
    public class BuildingUI : MonoBehaviour, IBuildingUI
    {
        [SerializeField] private Button _closeButton;

        public Action CloseUIAction;

        private void Start()
        {
            _closeButton.onClick += 
        }
    }
}