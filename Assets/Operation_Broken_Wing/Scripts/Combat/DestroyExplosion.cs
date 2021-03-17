using UnityEngine;

namespace Operation_Broken_Wing.Combat
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
