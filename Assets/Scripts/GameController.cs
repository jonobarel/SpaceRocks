﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public int currentLevel;
	public Asteroid asteroidPrefab;

	private int asteroidCount;

	// Use this for initialization
	void Start () {
		currentLevel = 0;
		asteroidCount = 0;
		InitializeLevel();
			
	}

	void InitializeLevel ()
	{

		for (int i = 0; i < currentLevel * 2 + 2;i++) {

			Vector3 newPos = new Vector3(Random.Range(2f,7f),Random.Range(2f,5.25f),0);
			Asteroid asteroid = (Asteroid)GameObject.Instantiate(asteroidPrefab,newPos,new Quaternion ());

			asteroid.transform.Rotate(Vector3.forward*Random.Range(1,360));
			asteroid.GetComponent<Rigidbody2D> ().AddForce (asteroid.transform.up * Random.Range (100f, 200f));	
			float torque = (float)(Random.Range(0,1)*2-1)*Random.Range (50f,100f);
			asteroid.GetComponent<Rigidbody2D> ().AddTorque (torque);


			Debug.Log ("Asteroid "+asteroid.GetInstanceID ()+"velocity magnitude :"+asteroid.GetComponent<Rigidbody2D> ().velocity);	
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddAsteroid() {
		asteroidCount++;
	}

	public void RemoveAsteroid() {
		asteroidCount--;
	}

	public int GetAsteroidCount() {
		return asteroidCount;
	}
}
