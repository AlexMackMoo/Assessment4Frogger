using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndDelte : MonoBehaviour
{
    [Header ("Setting the object")]
    public int amountOfEnemy;
    public GameObject Car1;

    [Header("Managing time")]
    public const float TTL = 5;
    private float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        amountOfEnemy = 0;
        timeCount = TTL;
    }

    // Update is called once per frame
    void Update()
    {
        //timeCount -= Time.deltaTime * 3f;
        //if (timeCount <= 0)
        //{
        //    do
        //    {
        //        for (int i = 0; i < 3; i++)
        //        {
        //            Instantiate(Car1);
        //            amountOfEnemy += 1;
        //        }
        //    } while (amountOfEnemy <= 3);
        //}

        //if (transform.position.x == -10)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
