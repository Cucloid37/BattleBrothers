using UnityEngine;

namespace Core
{
    public static class RayCastManager
    {
        public static GameObject RayCastReturn()
        {
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 100))
            {
                return hitInfo.collider.gameObject;
            }
            
            return null;
        }
    }
}