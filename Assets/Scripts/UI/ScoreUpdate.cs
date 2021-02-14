using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Operation_Broken_Arrow.UI
{
    public class ScoreUpdate : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _scoreText;
        private int _score;

        private void Awake()
        {
            _score = 0;
            _scoreText.SetText("Score: " + _score.ToString()); 
        }

        public void UpdateScoreText(int scoreToAdd)
        {
            _score += scoreToAdd;
            _scoreText.SetText("Score: " + _score.ToString());
        }
    }
}
