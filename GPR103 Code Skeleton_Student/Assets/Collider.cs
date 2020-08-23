using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public GameManager theGameManger;
    
    [Header("Player go touchie touchie")]
    public bool playerTouches;
    



    // Start is called before the first frame update
    void Start()
    {
        playerTouches = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
}
