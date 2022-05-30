using DragonSlayer.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonSlayer.Controller
{

    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] DirectionEnum direction;
        [SerializeField] float _moveSpeed = 5F;
        Rigidbody2D _rigidBody2D;
        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();

        }
        private void Start()
        {
            _rigidBody2D.velocity = selectNewDirection() * _moveSpeed;
        }
         private Vector2 selectNewDirection()
        {
            Vector2 selectedDirection;
                
            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            
            return selectedDirection;
        }
    }
    
}
