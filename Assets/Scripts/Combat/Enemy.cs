using System.Collections;
using UnityEngine;
using Operation_Broken_Arrow.Core;
using Operation_Broken_Arrow.Manager;

namespace Operation_Broken_Arrow.Combat
{
    public class Enemy : MonoBehaviour
    {
        private Transform _explosionContainer;
        [SerializeField]
        private GameObject _explosionPrefab;
        [SerializeField]
        private AudioClip _hitSound;

        [SerializeField]
        private int _hitsToDestroy;
        private bool _isDestroying;


        private void Start()
        {
            _isDestroying = false;

            _explosionContainer = GameObject.FindWithTag("Container").GetComponent<Transform>();
            if (_explosionContainer == null)
                Debug.LogError("Container is NULL.");
        }
        private void OnParticleCollision(GameObject other)
        {
            _hitsToDestroy--;
            AudioSource.PlayClipAtPoint(_hitSound, transform.position);
            if (_hitsToDestroy <= 0)
            DestroyGameObject();
        }

        private void DestroyGameObject()
        {        
            if (!_isDestroying)
            {
                _isDestroying = true;
                GenerateExplosion();
                int reward = GetComponent<EnemyReward>().Points;
                GameManager.Instance.UpdatePlayerScore(reward);
                Destroy(this.gameObject, 1f);
            }                     
        }

        private void GenerateExplosion()
        {
            GameObject explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.transform.parent = _explosionContainer;
        }

    }
}
