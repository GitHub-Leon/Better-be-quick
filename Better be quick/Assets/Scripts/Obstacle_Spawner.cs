using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();

    private int index;

    void Awake() {
        InitObstacles();
    }

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(SpawnRandomObstacle());
    }

    void InitObstacles() {
        index = 0;

        for (int i = 0; i < obstacles.Length * 5; i++) {
            GameObject obj = Instantiate(obstacles[index], transform.position, Quaternion.identity);
            obstaclesToSpawn.Add(obj);
            obstaclesToSpawn[i].SetActive(false);
            
            index++;
            if (index == obstacles.Length) {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomObstacle() {
        yield return new WaitForSeconds(Random.Range(1.5f, 4.5f)); // wait for a random amount of time

        int index = Random.Range(0, obstaclesToSpawn.Count);

        while(true) { // activates obstacles
            if (!obstaclesToSpawn[index].activeInHierarchy) {
                obstaclesToSpawn[index].SetActive(true);
                obstaclesToSpawn[index].transform.position = transform.position;
                break;
            } else {
                print((0, obstaclesToSpawn.Count));
                index = Random.Range(0, obstaclesToSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomObstacle());
    }
}
