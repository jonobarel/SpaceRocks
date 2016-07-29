using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max = 1000;
	int min = 1;

	int guess=500;


	void Start () {
	 	StartGame();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed!");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed!");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}

	//User methods
	private void StartGame () {
		max = 1000;
		min = 1;

		guess=500;

		print("================");
		print ("Welcome to the Number Wizard Machine!");
		print("pick a number");


		print("pick a number between "+min+" and "+max+".");
	}

	private void NextGuess ()
	{
		guess = (min + max) / 2;
		print("Higher or lower than "+guess);
	}
}
