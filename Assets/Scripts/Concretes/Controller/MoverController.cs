using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonSlayer.Controller
{


    public class MoverController : IMover
    {
        public float JumpAxis => Input.GetAxis("Jump");

        public void Jump(Rigidbody2D _rigidBody2D, float _jumpForce, bool _isJumpActive)
        {
            switch (_isJumpActive)
            {
                case true:
                    _rigidBody2D.AddForce(Vector2.up * _jumpForce * JumpAxis);
                    break;
                default:
                    break;
            }
        }
    }
}
