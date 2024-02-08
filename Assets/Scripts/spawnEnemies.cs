using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{

    public GameObject normalEnemy;
    public GameObject fastEnemy;
    public GameObject bigEnemy;

    public float targetTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            spawnEnemy();
            targetTime = 10.0f;
        }
    }

    void spawnEnemy()
    {
        var position = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0);

        int randomNum = Random.Range(0, 3);

        if (randomNum == 0)
        {
            Instantiate(normalEnemy, position, Quaternion.identity);
        }
        else if (randomNum == 1)
        {
            Instantiate(fastEnemy, position, Quaternion.identity);
        }
        else
        {
            Instantiate(bigEnemy, position, Quaternion.identity);
        }
    }
}
