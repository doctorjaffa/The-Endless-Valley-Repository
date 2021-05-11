using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    public string gameOverScene;

    void OnTriggerEnter2D(Collider2D collisionData)
    {
        //Get the objected collided with.
        Collider2D objectCollidedWith = collisionData;

        //Get PlayerHealth attached to that object (if there is one).
        PlayerHealth player = objectCollidedWith.GetComponent<PlayerHealth>();

        //Check if a player health script was found on the object collided with. 
        //This if statement is true if the player variable is NOT null (not empty).
        if (player != null)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
