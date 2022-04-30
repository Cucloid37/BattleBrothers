using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maps
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private AllDescriptions _descriptions;
        private ProfilePlayer _profilePlayer;
        private MainController _mainController;
    
        private void Start()
        {
            _profilePlayer = new ProfilePlayer();
            _mainController = new MainController(_descriptions, _profilePlayer);
        }
    }
}

