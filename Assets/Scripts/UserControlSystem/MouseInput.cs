using System;
using Core;
using UnityEngine;

namespace UserControlSystem
{
    public class MouseInput : IExecute, ICleanup
    {
        public Action OnClickMouseRight;
        public Action OnClickMouseLeft;
        
        public void Execute(float deltaTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClickMouseRight?.Invoke();
            }

            if (Input.GetMouseButtonDown(1))
            {
                OnClickMouseLeft?.Invoke();
            }
            
        }

        public void Cleanup()
        {
            OnClickMouseRight -= null;
            OnClickMouseRight -= null;
        }
    }
}