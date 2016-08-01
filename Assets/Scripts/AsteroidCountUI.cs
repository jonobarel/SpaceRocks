using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AsteroidCountUI : MonoBehaviour {
	//TODO - remove this class altogether, we don't need an AsteroidCount UI element, just a score.
	public GameController gc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text> ().text = "Asteroids remaining: "+gc.GetAsteroidCount();
	}
}
