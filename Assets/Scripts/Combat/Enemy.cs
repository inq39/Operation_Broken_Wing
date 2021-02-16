using System.Collections;
using UnityEngine;
using Operation_Broken_Arrow.Core;
using Operation_Broken_Arrow.Manager;

namespace Operation_Broken_Arrow.Combat
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private Transform _explosionContainer;
        [SerializeField]
        private GameObject _explosionPrefab;

        private void OnParticleCollision(GameObject other)
        {
            GenerateExplosion();
            Invoke("DestroyGameObject", 1f);
        }

        private void DestroyGameObject()
        {
            int reward = GetComponent<EnemyReward>().Points;
            GameManager.Instance.UpdatePlayerScore(reward);
            Destroy(this.gameObject);
        }

        private void GenerateExplosion()
        {
            GameObject explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.transform.parent = _explosionContainer;
        }

    }
}
