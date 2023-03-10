using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //deletes the object on the game once the object has not been seen anymore on the gameplay 
        if (transform.position.z > topBound)
        {
            //destroy removes game object, components, or assets that are no longer at view of the player
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            //log all the errors or tells that you want something to do in unity 
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
