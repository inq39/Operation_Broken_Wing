using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Operation_Broken_Arrow.Movement;

namespace Operation_Broken_Arrow.Core
{
    public class Collision : MonoBehaviour
    {
        private Scene _thisScene;
        private Player _player;
        [SerializeField]
        private ParticleSystem _particle;
        [SerializeField]
        private GameObject _mainExplosion;

        private void Start()
        {
            _thisScene = SceneManager.GetActiveScene();
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
            yield return new WaitForSeconds(2f);
            SceneManager.LoadSceneAsync(_thisScene.buildIndex);
        }
    }
}
