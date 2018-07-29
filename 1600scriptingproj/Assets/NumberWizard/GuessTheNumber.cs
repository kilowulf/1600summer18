using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour {

    // vars for num range
    int max;
    int min;
    int guess;


    // Use this for initialization
    void Start () {

        StartGame();
   	}

    void StartGame()
    {

        // vars for num range
        max = 1000;
        min = 1;
        guess = 500;

        // add one to max for rounding to whole num(takes max to 1000 instead of 999)
        

        // Intro
        print("==================================================");
        print("Welcome to Guess the Number!");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Press Up if number is higher, Down if lower and Return if equal.");
        max = max + 1;
    }    
	
	// Update is called once per frame
	void Update () {

        // decision control for key inputs
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {            
            min = guess;
            NextGuess();

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I Won!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Press Up if number is higher, Down if lower and Return if equal.");

    }
}
