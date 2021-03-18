using UnityEngine;

namespace Operation_Broken_Wing.Manager
{
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError(typeof(T).ToString() + " is NULL.");

            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
}
