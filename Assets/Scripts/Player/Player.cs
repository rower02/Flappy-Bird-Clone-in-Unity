using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
    public class Player : MonoBehaviour
    {
        public static Player instance;

        private void Awake()
        {
            instance = this;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Pipe")
            {
                GameManager.instance.Death();
                gameObject.SetActive(false);
            }
            if(collision.tag == "Points")
            {
                GameManager.instance.AddPoints(1);
            }
            if(collision.tag == "Blocker")
            {
                GameManager.instance.Death();
                gameObject.SetActive(false);
            }
        }
    }
}
