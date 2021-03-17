using UnityEngine;

namespace Operation_Broken_Wing.Movement
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _weapons;
        [SerializeField]
        [Range(5f, 20f)]
        private float _agility;
        private float _xAxis;
        private float _yAxis;
        [SerializeField]
        private float _rollFactor;
        [SerializeField]
        private float _yawFactor;
        [SerializeField]
        private float _pitchFactor;
        

        private void Update()
        {
            ProcessTranslation();
            ProcessRotation();
            ProcessFiring();
        }

        private void ProcessFiring()
        {
            if (Input.GetButton("Fire1"))
            {
                SetWeaponSystem(true);
            }
            else
            {
                SetWeaponSystem(false);
            }
        }

        private void SetWeaponSystem(bool status)
        {
            foreach (GameObject weapon in _weapons)
            {
                var emissionModule = weapon.GetComponent<ParticleSystem>().emission;
                emissionModule.enabled = status;
            }
        }

        private void ProcessRotation()
        {
            float roll = transform.localPosition.z - _rollFactor * _xAxis;
            float yaw = transform.localPosition.y + _yawFactor * _xAxis;
            float pitch = transform.localPosition.x - _pitchFactor * _yAxis;
            

            transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
        }

        private void ProcessTranslation()
        {
            _xAxis = Input.GetAxis("Horizontal");
            _yAxis = Input.GetAxis("Vertical");

            float newXPos = _xAxis * Time.deltaTime * _agility + transform.localPosition.x;
            float newYPos = _yAxis * Time.deltaTime * _agility + transform.localPosition.y;

            transform.localPosition = new Vector3(Mathf.Clamp(newXPos, -5f, 5f), Mathf.Clamp(newYPos, 0f, 7f), transform.localPosition.z);
        }
    }
}
