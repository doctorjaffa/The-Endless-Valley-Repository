using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HealthDisplay : MonoBehaviour
{

    //This will be the Text component that displays the health value.
    //Text = variable is in the form of a Text component.
    Text healthValueDisplay;

    //This will be the PlayerHealth component that contains information about the player's health.
    //PlayerHealth = variable is in the form of a PlayerHealth component.
    PlayerHealth player;

    //Built in Unity function.
    //Start is called before the first frame update.
    void Start()
    {
        //Get a Text component from the game object this script is attached to.
        //Store the Text component in healthValueDisplay variable.
        healthValueDisplay = GetComponent<Text>();

        //Search the scene for the object with PlayerHealth script attached.
        //Store the PlayerHealth component from object in player variable.
        player = FindObjectOfType<PlayerHealth>();
    }

    //Built in Unity function.
    //Update is called once per frame.
    void Update()
    {
        //Get current health value from the player using the GetHealth() function.
        //Change the number to text using ToString().
        //On the health value display Text component, set the text to be the number just retrieved.
        healthValueDisplay.text = player.GetHealth().ToString();
    }
}
