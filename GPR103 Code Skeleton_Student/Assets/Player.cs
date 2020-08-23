using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

/// <summary>
/// This script must be used as the core Player script for managing the player character in the game.
/// </summary>
public class Player : MonoBehaviour
{
    public string playerName = ""; //The players name for the purpose of storing the high score
   
    public int playerTotalLives; //Players total possible lives.
    public int playerLivesRemaining; //PLayers actual lives remaining.
    public int movementSpeed = 1;
    
    public bool playerIsHit;
    public bool playerIsAlive; //Is the player currently alive?
    public bool playerCanMove; //Can the player currently move?

    private GameManager myGameManager; //A reference to the GameManager in the scene.

    // Start is called before the first frame update
    void Start()
    {
        playerIsAlive = true;
        playerCanMove = true;
        playerTotalLives = 3;
        playerLivesRemaining = playerTotalLives;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsAlive == true)
        {
            Vector2 pos = transform.localPosition;

            if (Input.GetKeyDown(KeyCode.W)) // Move up when the W key is pressed
            {
                if (pos.y < 5)
                {
                    pos += Vector2.up;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S)) // Move down when the S key is pressed
            {
                if (pos.y > -5)
                {
                    pos += Vector2.down;
                }
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                if (pos.x > -2)
                {
                    pos += Vector2.left;
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (pos.x < 2)
                {
                    pos += Vector2.right;
                }
            }

            transform.localPosition = pos;
        }

        if (playerIsHit == true)
        {
            playerLivesRemaining -= 1;

            if (playerLivesRemaining == 0)
            {
                playerIsAlive = false;
                return;
            }
        }
    }

}
