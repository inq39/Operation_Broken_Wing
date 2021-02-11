using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Operation_Broken_Arrow.Movement
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        [Range(5f, 20f)]
        private float _agility;

        private void Update()
        {
            ProcessTranslation();
            ProcessRotation();
        }

        private void ProcessRotation()
        {
            //transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
        }

        private void ProcessTranslation()
        {
            float xAxis = Input.GetAxis("Horizontal");
            float yAxis = Input.GetAxis("Vertical");

            float newXPos = xAxis * Time.deltaTime * _agility + transform.localPosition.x;
            float newYPos = yAxis * Time.deltaTime * _agility + transform.localPosition.y;

            transform.localPosition = new Vector3(Mathf.Clamp(newXPos, -5f, 5f), Mathf.Clamp(newYPos, 0f, 5f), transform.localPosition.z);
        }
    }
}
