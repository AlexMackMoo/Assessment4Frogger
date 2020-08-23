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
   
    public int playerTotalLives = 3; //Players total possible lives.
    public int playerLivesRemaining; //PLayers actual lives remaining.
    
    public bool playerIsHit = false;
    public bool playerIsAlive = true; //Is the player currently alive?
    public bool playerCanMove = false; //Can the player currently move?

    private GameManager myGameManager; //A reference to the GameManager in the scene.

    // Start is called before the first frame update
    void Start()
    {
        playerLivesRemaining = playerTotalLives;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsAlive = true;)
        {
            if (Input.GetKeyDown(KeyCode.W)) // Move up when the W key is pressed
            {
                transform.Translate(Vector2.up * Time.deltaTime * movementSpeed);
            }
            else if (Input.GetKeyDown(KeyCode.S)) // Move down when the S key is pressed
            {
                transform.Translate(-Vector2.down * Time.deltaTime * movementSpeed);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(-Vector2.right * Time.deltaTime * movementSpeed);
            }
        }

        if (playerIsHit = true;)
        {
            playerLivesReamining -= 1;

            if (playerLivesRemaining = 0)
            {
                playerIsAlive = false;
                return;
            }
        }
    }

}
