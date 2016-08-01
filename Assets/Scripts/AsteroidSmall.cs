using UnityEngine;
using System.Collections;

public class AsteroidSmall : Asteroid {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Bullet") {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame

}
