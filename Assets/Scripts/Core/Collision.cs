using System.Collections;
using Manager;
using Movement;
using UnityEngine;

namespace Core
{
    public class Collision : MonoBehaviour
    {
        private Player _player;
        [SerializeField]
        private ParticleSystem _particle;
        [SerializeField]
        private GameObject _mainExplosion;

        private void Start()
        {
            _player = GetComponent<Player>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Terrain"))
            {
                StartCoroutine("RestartLevel");
            }
        }

        IEnumerator RestartLevel()
        {
            _player.enabled = false;
            _particle.Play();
            GetComponent<BoxCollider>().enabled = false;
            yield return new WaitForSeconds(3f);
            _particle.Stop();
            _mainExplosion.SetActive(true);
            yield return new WaitForSeconds(1f);
            GameManager.Instance.RestartLevel();
        }
    }
}
