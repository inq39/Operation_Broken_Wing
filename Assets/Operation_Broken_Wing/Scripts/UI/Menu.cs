using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    [RequireComponent(typeof(Canvas))]
    public class Menu : MonoBehaviour
    {
        public void OnBackButton()
        {
            
        }

        public void OnPlayButton()
        {
            LevelManager.Instance.LoadNextLevel();
        }

        public void OnOptionsButton()
        {
            
        }

        public void OnQuitButton()
        {
            LevelManager.Instance.QuitGame();
        }
    }
}
