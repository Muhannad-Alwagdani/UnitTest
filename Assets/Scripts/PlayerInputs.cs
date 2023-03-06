using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class PlayerInputs : MonoBehaviour
    {
        [SerializeField] private Vector2Reference moveInput;

        [SerializeField] private BoolReference hasMoveInput;
        [SerializeField] private GameEvent jumpEvent;

        public void Move(InputAction.CallbackContext ctx)
        {
            moveInput.Value = ctx.ReadValue<Vector2>();
            if (ctx.canceled)
            {
                hasMoveInput.Value = false;
                return;
            }

            hasMoveInput.Value = true;
        }

        public void Jump(InputAction.CallbackContext ctx)
        {
            if (ctx.started)
            {
                jumpEvent.Raise();
            }
        }
    }
}