using TMPro;
using UnityEngine;

namespace Operation_Broken_Wing.Manager
{
    public class UIManager : MonoSingleton<UIManager>
    {
        [SerializeField]
        private TextMeshProUGUI _highScoreText;
        [SerializeField]
        private TextMeshProUGUI _scoreText;

        public void UpdateScoreText(int scoreValue)
        {
            _scoreText.SetText("Score: " + scoreValue.ToString());
        }

        public void UpdateHighScoreText(int newHighScore)
        {
            _highScoreText.SetText("Best Score: " + newHighScore.ToString());
        }
    }
}
