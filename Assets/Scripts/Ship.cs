using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public Bullet bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter() {
		Debug.Log("Ship collider triggered.");
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("up")) {
			//Debug.Log ("UP key pressed");
			//TODO - change the acceleration to a variable/constant
			gameObject.GetComponent<Rigidbody2D> ().AddForce (gameObject.transform.up * 2f);
			//return Quaternion.AngleAxis(_angle, Vector3.forward) * normalizedDirection;
		}

		//TODO add support for axis/input support
		if (Input.GetAxis ("Horizontal") != 0) {
			//Debug.Log ("Input Horizontal: " + Input.GetAxis ("Horizontal"));
		}
			if (Input.GetKey("left")) {
			//TODO - change the rotation speed to a variable
			gameObject.transform.Rotate(Vector3.forward*2);
		}
		if (Input.GetKey("right")) {
			//Debug.Log("Right key - ship rotation: "+gameObject.transform.rotation.ToString());
			//TODO - change the rotation speed to a variable
			gameObject.transform.Rotate(Vector3.forward*-2);
		}

		if (Input.GetKeyDown("space")) {
			Vector3 newPos = transform.position+transform.forward;

			newPos.x*=GetComponent<SpriteRenderer>().bounds.size.y/2;
			newPos.z+=1;

			Bullet bullet = (Bullet)Instantiate(bulletPrefab,newPos, transform.rotation);

			bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.up*1000f);
		}
	}
}
