using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public int score, bestScore;

        [Header("UI")]
        public Text scoreText;

        private void Awake()
        {
            instance = this;
            score = 0;
            bestScore = PlayerPrefs.GetInt("BestScore");
        }

        public void Death()
        {
            if(score > bestScore)
            {
                bestScore = score;
                PlayerPrefs.SetInt("BestScore", bestScore);
            }

            DeathUI.instance.gameObject.SetActive(true);
            DeathUI.instance.Open();
        }

        public void AddPoints(int value)
        {
            score += value;
            scoreText.text = score.ToString();
        }
    }
}
