using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
	public AsteroidSmall asteroidSmallPrefab;

	// Use this for initialization

	void Start () {
	  
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Bullet") {
			//spawn two mini-asteroids and destroy self
			for (int i=0; i<2;i++) //TODO make the number of small asteroids ajustable or randomised
			{
				//TODO cleanup this process, it looks ridiculously complicated
				int[] signs = {-1,1};


				//this creates a quaternion for the direction in which the asteroid is flying
				Quaternion direction = Quaternion.FromToRotation (Vector3.up,gameObject.GetComponent<Rigidbody2D> ().velocity);

				AsteroidSmall astSm = (AsteroidSmall)GameObject.Instantiate (asteroidSmallPrefab,gameObject.transform.position,direction);

				//Rotate the small asteroid 30 degrees each way, creates the illusion of the small asteroids continuing in the general 
				//direction of the big
				astSm.transform.Rotate (astSm.transform.forward*signs[i%2]*30);
				astSm.GetComponent<Rigidbody2D> ().AddForce (astSm.transform.up*Random.Range (50f,100f));

				//Give the small asteroid some spin
				float torque = (float)(Random.Range(0,1)*2-1)*Random.Range (50f,100f);
				astSm.GetComponent<Rigidbody2D> ().AddTorque(torque);
			}

			Destroy (gameObject);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
