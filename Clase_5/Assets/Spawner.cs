using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject player;
    protected float time2Spawn;
    public float timer = 0;

    private void Start()
    {
        Instantiate(player);
    }

    void Update()           
    {
        timer += Time.deltaTime;
        time2Spawn = Random.Range(2.5f, 6f);
        int ejeXrmd = Random.Range(0, 4);

        if (timer >= time2Spawn)
        {
            int rmdObstacle = Random.Range(0,obstacles.Length);
            switch (ejeXrmd)
            {
                case 0:
                    Instantiate(obstacles[rmdObstacle], new Vector3(-2,6,0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(obstacles[rmdObstacle], new Vector3(-1, 6, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(obstacles[rmdObstacle], new Vector3(0, 6, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(obstacles[rmdObstacle], new Vector3(1, 6, 0), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(obstacles[rmdObstacle], new Vector3(2, 6, 0), Quaternion.identity);
                    break;
            }
            timer = 0;
        }
    }
}
