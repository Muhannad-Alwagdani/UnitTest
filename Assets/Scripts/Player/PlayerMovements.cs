using System;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace DefaultNamespace.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovements : MonoBehaviour
    {
        [SerializeField] private Vector2Reference inputVectorReference;
        [SerializeField] private BoolReference hasMovementInput;
        [SerializeField] private float speed;
        [SerializeField] private AnimationCurve scaleCurve;
        private CharacterController characterController;


        private float scaleTimer;
        [SerializeField] private float scaleSpeed;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
        }


        private void Start()
        {
            scaleTimer = 0f;
        }

        private void Update()
        {
            // Vector3 movementVector = Vector3.zero;
            // if (hasMovementInput != null && hasMovementInput.Value)
            // {
            //     movementVector.x = inputVectorReference.Value.x;
            //     movementVector.z = inputVectorReference.Value.y;
            //     movementVector *= (speed * Time.deltaTime);
            // }
            //
            //
            // if(Input.GetKeyDown(KeyCode.Space))
            // {
            //     movementVector.y = 10f;
            // }
            // else
            // {
            //     
            // }
            //
            //
            //
            // if (Input.GetKey(KeyCode.LeftShift))
            // {
            //     scaleTimer += Time.deltaTime * scaleSpeed;
            // }
            // else
            // {
            //     scaleTimer -= Time.deltaTime * scaleSpeed;
            // }
            // scaleTimer = Mathf.Clamp01(scaleTimer);
            //
            // transform.localScale = new Vector3(1f, scaleCurve.Evaluate(scaleTimer), 1f);
            //
            //
            // if (!characterController.isGrounded)
            // {
            //     movementVector.y += -1f;
            //     movementVector.y = Mathf.Clamp(movementVector.y, -1f, 0);
            // }
            // else
            // {
            //     movementVector.y = 0f;
            // }
            //
            //
            // Move(movementVector);
        }

        private float Jump()
        {
            throw new NotImplementedException();
        }

        public void Move(Vector3 movementDirection)
        {
            characterController.Move(movementDirection );
        }
    }
}