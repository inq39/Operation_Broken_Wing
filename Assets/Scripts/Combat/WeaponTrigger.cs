using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation_Broken_Arrow.Combat
{
    public class WeaponTrigger : MonoBehaviour
    {
        private void OnParticleCollision(GameObject other)
        {
            Debug.Log("Hit: " + this.name + " by " + other.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
