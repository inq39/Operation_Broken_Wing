using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Operation_Broken_Arrow.Manager
{
    public class UIManager : MonoSingleton<UIManager>
    {
        [SerializeField]
        private TextMeshProUGUI _scoreText;

        private void Start()
        {
            _scoreText.SetText("Score: 0");
        }

        public void UpdateScoreText(int scoreValue)
        {
            _scoreText.SetText("Score: " + scoreValue.ToString());
        }
    }
}
