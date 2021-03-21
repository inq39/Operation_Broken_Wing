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
        private bool _isGamePaused;
        public bool IsGamePaused { get { return _isGamePaused; } }

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
            MenuManager.Instance.OpenMenu(MainMenu.Instance);
        }
        public void PauseLevel()
        {
            _isGamePaused = true;
            Time.timeScale = 0f;
            AudioManager.Instance.PressButton();
            MenuManager.Instance.OpenMenu(PauseMenu.Instance);
        }

        public void ResumeLevel()
        {
            Time.timeScale = 1f;
            _isGamePaused = false;
        }
        
    }
}
