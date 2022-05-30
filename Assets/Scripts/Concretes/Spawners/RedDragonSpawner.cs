using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonSlayer.Controller;
using DragonSlayer.Abcstracs.Spawners;

namespace DragonSlayer.Spawners
{


    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyLife enemy;
        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }
}