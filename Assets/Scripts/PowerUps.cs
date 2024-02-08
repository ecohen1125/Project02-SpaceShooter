using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    public GameObject speedPower;
    public GameObject healthPower;

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
            spawnPower();
            targetTime = 10.0f;
        }
    }

    void spawnPower()
    {
        var position = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0);

        if (Random.Range(0, 2) == 0)
        {
            Instantiate(healthPower, position, Quaternion.identity);
        }
        else
        {
            Instantiate(speedPower, position, Quaternion.identity);
        }
    }
}
