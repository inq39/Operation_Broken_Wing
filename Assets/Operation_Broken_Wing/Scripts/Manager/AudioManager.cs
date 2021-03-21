using UnityEngine;
using UnityEngine.Serialization;

namespace Operation_Broken_Wing.Manager
{
    public class AudioManager : MonoSingleton<AudioManager>
    {
        [FormerlySerializedAs("_buttonClick")]
        [SerializeField]
        private AudioSource _buttonOver;
        [SerializeField]
        private AudioSource _buttonPress;

        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
        
        public void OverButton()
        {
            _buttonOver.Play();
        }

        public void PressButton()
        {
            _buttonPress.Play();
        }
    }
}
