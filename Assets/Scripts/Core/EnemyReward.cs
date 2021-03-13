using UnityEngine;

namespace Core
{
    public class EnemyReward : MonoBehaviour
    {
        [SerializeField]
        private int _points;
        public int Points { get => _points; }

    }
}
