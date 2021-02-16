using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Operation_Broken_Arrow.Manager
{
    public class GameManager : MonoSingleton<GameManager>
    {
        [SerializeField]
        private int _score;
        public int Score { get => _score; }

        private Scene _thisScene;


        private void Start()
        {
            _thisScene = SceneManager.GetActiveScene();

            _score = 0;
        }

        public void UpdatePlayerScore(int scoreUpdate)
        {
            _score += scoreUpdate;
            UIManager.Instance.UpdateScoreText(_score);
        }

        public void RestartLevel()
        {
            SceneManager.LoadSceneAsync(_thisScene.buildIndex);
        }
    }
}
