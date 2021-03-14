using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class LevelManager : MonoSingleton<LevelManager>
    {
        [SerializeField]
        private GameObject _mainMenu;
        [SerializeField]
        private GameObject _optionMenu;
        [SerializeField]
        private string _nextLevel;

        private Scene _activeLevel;

        public void Start()
        {
            _activeLevel = SceneManager.GetActiveScene();
        }
            
        public void LoadNextLevel()
        {
            if (Application.CanStreamedLevelBeLoaded(_nextLevel))
            {
                SceneManager.LoadScene(_nextLevel);
            }
        }

        public void ReloadLevel()
        {
            SceneManager.LoadScene(_activeLevel.buildIndex);
        }

        public void OpenOptionMenu()
        {
            _optionMenu.SetActive(true);
            _mainMenu.SetActive(false);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void ReturnToMainMenu()
        {
            _optionMenu.SetActive(false);
            _mainMenu.SetActive(true);
        }
    }
}
