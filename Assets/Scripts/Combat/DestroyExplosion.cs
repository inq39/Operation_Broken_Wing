using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation_Broken_Arrow.Combat
{
    public class DestroyExplosion : MonoBehaviour
    {
        [SerializeField]
        private int _destroyDelay;

        void Start()
        {
            Destroy(this.gameObject, _destroyDelay);
        }

    }
}
