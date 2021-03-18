using System;
using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    public abstract class Menu<T> : Menu where T : Menu<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError( typeof(T).ToString()+ " is NULL.");

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
                Destroy(gameObject);
            }
        }
    }
    
    [RequireComponent(typeof(Canvas))]
    public abstract class Menu : MonoBehaviour
    {
        public virtual void OnBackButton()
        {
            MenuManager.Instance.CloseMenu();
        }
    }
}
