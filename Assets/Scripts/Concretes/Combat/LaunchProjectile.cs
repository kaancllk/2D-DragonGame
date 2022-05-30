using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonSlayer.Controller;

namespace DragonSlayer.Combats
{


    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefabs;
        [SerializeField] Transform projectileTransform;
        

        [SerializeField] GameObject projecttileParents;

        public void LunchAction()
        {
           ProjectileController newProjectile = Instantiate
            (projectilePrefabs,projectileTransform.position,projectileTransform.rotation);
            newProjectile.transform.parent = projecttileParents.transform;           
        }
    }
}
