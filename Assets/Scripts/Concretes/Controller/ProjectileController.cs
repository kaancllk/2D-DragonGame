using DragonSlayer.Abcstracs.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonSlayer.Controller
{


    public class ProjectileController : LifeControl
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyLife enemy = collision.GetComponent<EnemyLife>();
           
            {
               
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}