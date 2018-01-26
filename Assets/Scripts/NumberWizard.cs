using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Number Wizard");
        print("QUICK! PICK A NUMBER IN YOUR SKULL!");

        int max = 1000;
        int min = 1;

        print("The highest number you can pick is" + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than 500?");
        print("Up = Higher, Down = Lower, Return = Equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow is pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow is pressed");
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("I won! Mwahahaha");
        }

    }
}
