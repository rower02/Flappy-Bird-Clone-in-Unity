using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Pipe
{
    public class PipeMovement : MonoBehaviour
    {
        private void Update()
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
    }
}