using UnityEngine;

namespace Combat
{
    public class DestroyExplosion : MonoBehaviour
    {
        [SerializeField]
        private int _destroyDelay;

        void Start()
        {
            Destroy(this.gameObject, _destroyDelay);
        }

    }
}
