using UnityEngine;

namespace Operation_Broken_Wing.Manager
{
    public class AudioManager : MonoSingleton<AudioManager>
    {
        [SerializeField]
        private AudioSource _buttonClick;
        [SerializeField]
        private AudioSource _buttonPress;


        public void ClickButton()
        {
            _buttonClick.Play();
        }

        public void PressButton()
        {
            _buttonPress.Play();
        }
    }
}
