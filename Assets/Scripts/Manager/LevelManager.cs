using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class LevelManager : MonoSingleton<LevelManager>
    {
        [SerializeField]
        private Scene _mainMenu;
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
    }
}
