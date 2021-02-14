using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Operation_Broken_Arrow.UI;
using Operation_Broken_Arrow.Core;

namespace Operation_Broken_Arrow.Combat
{
    public class WeaponTrigger : MonoBehaviour
    {
        [SerializeField]
        private Transform _explosionContainer;
        [SerializeField]
        private GameObject _explosionPrefab;

        private void OnParticleCollision(GameObject other)
        {
            StartCoroutine("DestroyGameObject");
        }

        IEnumerator DestroyGameObject()
        {
            GameObject explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.transform.parent = _explosionContainer;
            Destroy(explosion, 3f);
            yield return new WaitForSeconds(1f);
            
            GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(3f);
            int reward = GetComponent<EnemyReward>().Points;
            GameObject.FindGameObjectWithTag("UI").GetComponent<ScoreUpdate>().UpdateScoreText(reward);
            Destroy(this.gameObject);
        }
    }
}
