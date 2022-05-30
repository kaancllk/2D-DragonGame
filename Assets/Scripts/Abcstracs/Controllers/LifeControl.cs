using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonSlayer.Abcstracs.Controllers
{


    public  abstract class LifeControl : MonoBehaviour
    {
        [SerializeField] float _maxLifeTime = 5f;
        float _currentTime;
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
