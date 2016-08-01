using UnityEngine;
using System.Collections;

public class Wrapper : MonoBehaviour {
	Camera cam;

	// Use this for initialization
	void Start () {
		Debug.Log("Getting Camera");
		cam = Camera.main;

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Vector3 viewPos = cam.WorldToViewportPoint (other.gameObject.transform.position);
		//Debug.Log("OnTriggerEnter "+other.gameObject.name+" collided with "+this.gameObject.name);
		if (other.tag != "Bullet") {
			
			float _newX;
			float _newY;

			if (viewPos.x >= 1f) {
				_newX = -7.5f;
			} else if (viewPos.x <= 0f) {
				_newX = 7.5f;
			} else _newX = viewPos.x;

			if (viewPos.y >= 1f) {
				_newY = -5.5f;
			} else if (viewPos.y <=	 0f) {
				_newY = 5.5f;
			} else _newY = viewPos.y;

			Vector3 newPos = new Vector3(_newX, _newY, viewPos.z);
			//Debug.Log (this.name + " : " + other.name + "from "+viewPos.ToString()+" to " + newPos.ToString());

			//Vector3 newPos = cam.ViewportToWorldPoint(newPos);
			other.gameObject.transform.position = newPos;
			} //if != TypeOf(Bullet)
			else if (other.tag == "Bullet"){
				Destroy(other.gameObject);
			}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
