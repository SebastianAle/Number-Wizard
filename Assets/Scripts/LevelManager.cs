using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Load level requested: " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitLevel(){
		Debug.Log ("I want to quit!");
	}
}
