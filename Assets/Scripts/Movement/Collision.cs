using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation_Broken_Arrow.Movement
{
    public class Collision : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Collision with: " + other.gameObject.name);
        }
    }
}
