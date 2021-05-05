using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    //This will be the starting health for the player. 
    //Public variable = shown in Unity editor and accessible from other scripts.
    //Int = whole numbers. 
    public int startingHealth;

    //This will be the player's current health.
    //Private variable = NOT shown in Unity or accessible from other scripts.
    //Int = whole numbers.
    private int currentHealth;

    //Built in Unity function called when the object this script is attached to is created.
    //Usually this is when the game starts unless the object is spawned in later.
    //This happens BEFORE the Start() function.
    //Usually used for initialisation.
    void Awake()
    {
        //Initialise current health to be equal to starting health at beginning of game.
        currentHealth = startingHealth;
    }

    //This function is NOT built into Unity. 
    //It will only be called manually by own code. 
    //It must be marked 'public' so other scripts can access it. 
    //This function will change the health value of the player.
    public void ChangeHealth(int changeAmount)
    {
        //Take current health, add the change amount and store the result back into current health.
        currentHealth += changeAmount;

        //Current health cannot go below zero or above starting health so special 
        //function "Clamp" is used to keep it between 0 and the starting health.
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        //If health has dropped to 0, the player should die.
        if (currentHealth == 0)
        {
            //Call the Kill function to kill the player.
            Kill();

        }

        if (currentHealth > startingHealth)
        {
            currentHealth--;
        }
    }

    //This function is NOT built into Unity. 
    //It will only be called manually by own code. 
    //It must be marked 'public' so other scripts can access it. 
    //This function will kill the player.
    public void Kill()
    {
        //This will destroy the gameObject this script is attached to.
        Destroy(gameObject);
    }

    //This simple function will let other scripts ask this one what the current health is.
    //The function RETURNS an integer, meaning it gives a number back to the code that called it.
    public int GetHealth()
    {
        return currentHealth;
    }

    //This simple function will let other scripts ask this one what the max health is.
    //The function RETURNS an integer, meaning it gives a number back to the code that called it.
    public int GetMaxHealth()
    {
        return startingHealth;
    }
}