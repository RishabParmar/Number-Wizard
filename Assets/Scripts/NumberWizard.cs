using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;

    void RestartTheGame()
    {
        max = 1000;
        min = 1;
        Start();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Wizard Number yo!!!");
        Debug.Log("Pick a number and don't tell me what it is!!!");
        Debug.Log("The highest number: " + max + " and the lowest: " + min);
        Debug.Log("Is your number greater than " + (max+min)/2 + " ? Press 'y' for yes or 'n' for no");
        Debug.Log("Press 'Enter' if you have correctly guessed your answer");
        // max += 1: So that 1000 is inclusive of the range 1 - 1000
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.N))
        {
            max = (max + min) / 2;
            Debug.Log("Is your number greater than " + (max + min) / 2 + " ? Press 'y' for yes or 'n' for no");
        } else if (Input.GetKeyDown(KeyCode.Y))
        {
            min = (max + min) / 2;        
            Debug.Log("Is your number greater than " + (max + min) / 2 + " ? Press 'y' for yes or 'n' for no");
        } else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number was: " + (max + min) / 2);
            RestartTheGame();
        }
    }
}
