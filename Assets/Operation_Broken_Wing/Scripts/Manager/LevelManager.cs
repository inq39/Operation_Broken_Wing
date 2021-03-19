using Operation_Broken_Wing.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Operation_Broken_Wing.Manager
{
    public class LevelManager : MonoSingleton<LevelManager>
    {
        [SerializeField]
        private string _nextLevel;

        private Scene _activeLevel;
        [SerializeField]
        private int _mainMenuIndex;
        [SerializeField]
        private GameObject _pauseMenu;

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
            Time.timeScale = 1f;
            SceneManager.LoadScene(_activeLevel.buildIndex);
        }
        
        public void QuitGame()
        {
            Application.Quit();
        }

        public void ReturnToMainMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(_mainMenuIndex);
        }
        public void PauseGame()
        {
            Time.timeScale = 0f;
            _pauseMenu.SetActive(true);
        }

        public void ResumeGame()
        {
            _pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        
    }
}
