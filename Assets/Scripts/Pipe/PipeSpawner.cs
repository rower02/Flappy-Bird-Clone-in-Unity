using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Pipe
{
    public class PipeSpawner : MonoBehaviour
    {
        public GameObject pipePrefab;
        public int pipeAmount;
        float lastXPipePos;
        public int index;
        public List<GameObject> pipes = new List<GameObject>();

        private void Start()
        {
            GameObject firstPipe = Instantiate(pipePrefab, new Vector2(5, Random.Range(-2, 3)), Quaternion.identity);
            firstPipe.AddComponent<PipeMovement>();
            lastXPipePos = firstPipe.transform.position.x;
            pipes.Add(firstPipe);
           // GeneratePipes();
        }

        private void Update()
        {
            if (pipes[pipes.Count-1].transform.position.x < 1f)
            {
                GeneratePipe();
            }
            if (pipes[0].transform.position.x < -8f)
            {
                Destroy(pipes[0]);
                pipes.RemoveAt(0);
            }
        }

        void GeneratePipes()
        {
            for(int i = 0; i < pipeAmount; i++)
            {
                GeneratePipe();
            }
        }

        void GeneratePipe()
        {
            GameObject pipe = Instantiate(pipePrefab, new Vector2(lastXPipePos + 0.5f, Random.Range(-3, 3)), Quaternion.identity);
            pipe.AddComponent<PipeMovement>();
            pipes.Add(pipe);
            lastXPipePos = pipe.transform.position.x;
            index++;
        }
    }
}
