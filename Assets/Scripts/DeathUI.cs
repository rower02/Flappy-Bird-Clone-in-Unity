using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts {
    public class DeathUI : MonoBehaviour
    {
        public static DeathUI instance;

        public Text scoreTxt;
        public Text bestScoreTxt;

        private void Awake()
        {
            instance = this;
            gameObject.SetActive(false);
        }

        private void Start()
        {
            scoreTxt.text = "Score: " + GameManager.instance.score.ToString();
            bestScoreTxt.text = "Best Score: " + GameManager.instance.bestScore.ToString();

        }

        public void Respawn()
        {
            SceneManager.LoadScene("SampleScene");
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
