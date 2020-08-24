using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnAndDelte : MonoBehaviour
{
    [Header ("Setting the object")]
    public GameObject Car1;

    [Header("Managing time")]
    public float spawnTimer;
    public float timer;
    public float deleteTimer;
    public float secondTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 2f;
        deleteTimer = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {   
           for (int i = 0; i < 1; i++)
           {
                Instantiate(Car1);
                timer = 0f;
           }
           
        }

        secondTimer += Time.deltaTime;
        if (secondTimer >= deleteTimer)
        {
            Destroy(GameObject.Find("FirstLane(Clone)"));
        }

    }
}
