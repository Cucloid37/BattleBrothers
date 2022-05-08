using System;
using UnityEngine;

namespace Core
{
    public class BuildingView : MonoBehaviour
    {
        public event Action OnTrigger;
        
        // Что должна хранить вьюха?
        private Transform _transform;
        private Material _material;

        private void Start()
        {
            _transform = gameObject.transform;
            _material = GetComponent<Material>();
            
            Debug.Log($"Мы инициализировали здание, цвет: {_material.color}");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<CapsuleCollider>())  // переменить в дальнейшем проверку на скрипт или т.п.
            {
                OnTrigger?.Invoke();
            }
        }

        private void OnDestroy()
        {
            OnTrigger -= null;
        }
    }
}