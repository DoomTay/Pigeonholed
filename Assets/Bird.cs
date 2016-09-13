using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * -Input.GetAxis("Horizontal"));
		//print (Input.GetAxis ("Vertical"));
		if (Input.GetAxis ("Vertical") > 0)
			rb.AddForce (transform.up * 25 * Input.GetAxis ("Vertical"));
		Camera.main.transform.position -= new Vector3 (((Camera.main.transform.position.x - transform.position.x) / 10), ((Camera.main.transform.position.y - transform.position.y) / 10), 0);
	}
}
