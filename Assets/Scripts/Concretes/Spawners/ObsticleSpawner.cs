using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonSlayer.Controller;
using DragonSlayer.Abcstracs.Spawners;

namespace DragonSlayer.Spawners
{


    public class ObsticleSpawner : BaseSpawner
    {

        [SerializeField] EnemyLife[] _enemies;
        

       
       

        protected override void Spawn()
        {
            {
                int enemyIndex = Random.Range(0, _enemies.Length);
                Instantiate(_enemies[enemyIndex], this.transform);
            }
        }
        
    }
}
