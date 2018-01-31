using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;

    void Start () {
        StartGame () ;
	}

    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;
       
        print("_________________________");
        print("Welcome to Number Wizard");
        print("QUICK! PICK A NUMBER IN YOUR SKULL!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = Higher, Down = Lower, Return = Equal");

        max = max + 1;
    }



    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won! Mwahahaha");
            StartGame();
        }
    }

        void NextGuess () {
            guess = (max + min) / 2;
            print("Higher or lower than " + guess + "?");
            print("Up = Higher, Down = Lower, Return = Equal");
    }
   
}
