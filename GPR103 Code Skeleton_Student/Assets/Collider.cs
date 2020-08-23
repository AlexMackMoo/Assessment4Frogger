using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [Header("Player go touchie touchie")]
    public bool playerTouches;
    public bool playerHit;

    [Header("The Border")]
    public float playerMinX;
    public float playerMaxX;
    public float playerMinY;
    public float playerMaxY;



    // Start is called before the first frame update
    void Start()
    {
        playerTouches = false;
        playerHit = false;
    }

    // Update is called once per frame
    void Update()
    {

        playerMinX = -7f;
        playerMaxX = 7f;
        playerMinY = 7f;
        playerMaxY = -7f;

        Vector2 pos = transform.localPosition;

        if (playerMinX == transform.position.x)
        {
            playerTouches = true;

        }


    }
}
