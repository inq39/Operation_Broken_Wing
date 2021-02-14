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

        private void Start()
        {
            _thisScene = SceneManager.GetActiveScene();
            _player = GetComponent<Player>();
            //var emission = _particle.emission;
            //emission.enabled = true;

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
            yield return new WaitForSeconds(3f);
            SceneManager.LoadSceneAsync(_thisScene.buildIndex);
        }
    }
}
