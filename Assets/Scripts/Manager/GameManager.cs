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

        private int _thisScene;


        private void Start()
        {
            _thisScene = SceneManager.GetActiveScene().buildIndex;

            ResetScore();
            UpdatePlayerScore(_score);
            UIManager.Instance.UpdateHighScoreText(_highScore);
        }

        private void ResetScore()
        {
            _score = 0;
            UIManager.Instance.UpdateScoreText(_score);
        }

        public void UpdatePlayerScore(int scoreUpdate)
        {
            _score += scoreUpdate;
            UIManager.Instance.UpdateScoreText(_score);
            CheckForNewHighscore();
        }

        public void RestartLevel()
        {
            ResetScore();
            SceneManager.LoadSceneAsync(_thisScene);
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
