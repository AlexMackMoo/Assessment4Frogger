using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

/// <summary>
/// This script must be utlised as the core component on the 'vehicle' obstacle in the frogger game.
/// </summary>
public class Vehicle : MonoBehaviour
{
    /// <summary>
    /// -1 = left, 1 = right
    /// </summary>
    public int moveDirection; //This variabe is to be used to indicate the direction the vehicle is moving in.
    public float speed; //This variable is to be used to control the speed of the vehicle.
    public Vector2 startingPosition; //This variable is to be used to indicate where on the map the vehicle starts (or spawns)
    public Vector2 endPosition; //This variablle is to be used to indicate the final destination of the vehicle.

    public bool otherWay;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startingPosition;
        //otherWay = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y == -4)
        {
            speed = 5f;
        }
        if (transform.position.y == -3)
        {
            speed = 7f;
        }
        if (transform.position.y == -2)
        {
            speed = 10f;
        }
        if (transform.position.y == -1)
        {
            speed = 15f;
        }
            moveDirection = -1;
            transform.Translate(Vector2.right * Time.deltaTime * speed * moveDirection);

            if ((transform.position.x * moveDirection) > (endPosition.x * moveDirection))
            {
                transform.position = startingPosition;
            }

        //else if (otherWay == true)
        //{
        //    this.transform.position = endPosition;
        //    moveDirection = 1;
        //    speed = 5f;
        //    transform.Translate(Vector2.right * Time.deltaTime * speed * moveDirection);

        //    if ((transform.position.x * moveDirection) > (endPosition.x * moveDirection))
        //    {
        //        transform.position = endPosition;
        //    }
        //}
    }

    private void OnTriggerEnter2d(Collider2D collision)
    {

    }

}
