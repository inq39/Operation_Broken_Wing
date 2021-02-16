using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Operation_Broken_Arrow.Manager
{
    public class GameManager : MonoSingleton<GameManager>
    {
        private int _highScore;
        public int HighScore { get => _highScore;  }
        private int _score;
        public int Score { get => _score; }

        private Scene _thisScene;


        private void Start()
        {
            _thisScene = SceneManager.GetActiveScene();

            _score = 0;
            UpdatePlayerScore(_score);
            UIManager.Instance.UpdateHighScoreText(_highScore);
        }

        public void UpdatePlayerScore(int scoreUpdate)
        {
            _score += scoreUpdate;
            UIManager.Instance.UpdateScoreText(_score);
            CheckForNewHighscore();
        }

        public void RestartLevel()
        {
            SceneManager.LoadSceneAsync(_thisScene.buildIndex);
        }

        private void CheckForNewHighscore()
        {
            if (_score > _highScore)
            {
                _highScore = _score;

                UIManager.Instance.UpdateHighScoreText(_highScore);
            }
        }
    }
}
