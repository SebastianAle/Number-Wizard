using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	public Text text;

	public int maxGuessesAllowed = 7;
	// Use this for initialization
	void Start () {
		StartGame ();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess ();
	}

	void NextGuess (){
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
		maxGuessesAllowed--;

		if (maxGuessesAllowed <= 0) 
		{
			SceneManager.LoadScene ("Win");
		}
	}
}
