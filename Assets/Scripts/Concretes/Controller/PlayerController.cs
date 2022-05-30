using DragonSlayer.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonSlayer.Controller
{

public class PlayerController : MonoBehaviour
    {

        MoverController _moveController;
        [Header("CharacterJumpSettings")][SerializeField] bool _isJumpActive;
        [Header("CharakterJumpForce")][Range(250, 450)][SerializeField] float _jumpForce;
        Rigidbody2D _rigidBody2D;
        bool _spaceController;
        LaunchProjectile _launchProjectile;
        private void Awake()
        {
            _moveController = new MoverController();
            _rigidBody2D = GetComponent<Rigidbody2D>();
            _launchProjectile = GetComponent<LaunchProjectile>();
        }
        private void FixedUpdate()
        {
            Jump();
        }
        private void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                _spaceController = true;
            }
            if (Input.GetMouseButtonDown(0))
            {
                _launchProjectile.LunchAction();
            }
        }
        void Jump()
        {
            if (_spaceController)
            {
                _moveController.Jump(_rigidBody2D, _jumpForce, _isJumpActive);
            }
            _spaceController = false;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
         

}