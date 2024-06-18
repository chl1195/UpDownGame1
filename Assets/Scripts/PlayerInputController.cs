using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : UpDownController
{
        private Camera camera;
        private void Awake()
        {
            camera = Camera.main;
        }

        public void OnMove(InputValue value)
        {
            Vector2 moveInput = value.Get<Vector2>().normalized;
            CallMoveEvent(moveInput);
        }
}
