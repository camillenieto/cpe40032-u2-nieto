using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    //new variable speed
    public float speed = 10.0f;
    //new variable for the boundary of the player
    public float xRange = 19.0f;
    //new variable for reference of player to the food 
    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creates a boundary so that the player do not fall outside the game screen
        if (transform.position.x < -xRange)
        {
            //bounding the movement of the player into certain range which is -10 (to the left)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            //bounding the movement of the player into certain range which is 10 (to the right)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        //to be able to move the player left or right over that speed at that period of time. 
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); 

        //makes to fireoff all the projectiles using a spacebar
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Launch projectile from a player
            //Instantiate creates copies of object that already exists eg. projectileprefab
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }


    }
}
