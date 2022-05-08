using UserControlSystem;

namespace Core
{
    public class MapsController : BaseController
    {
        private readonly MouseInput _mouseInput;
        //private readonly ProfilePlayer _profile;
        
        
        public MapsController(MouseInput mouseInput, MapsInitialisation initialisation)
        {
            _mouseInput = mouseInput;
            //_profile = profile;
            
            _mouseInput.OnClickMouseLeft += ChangeLastTarget;
        }

        private void ChangeLastTarget()
        {
            ProfilePlayer.LastClickTarget.Value = RayCastManager.RayCastReturn().transform;
        }

        protected override void OnDispose()
        {
            _mouseInput.OnClickMouseLeft -= ChangeLastTarget;
        }
    }
}