using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	private Rigidbody2D rb;
	public int lives = 5;
	private Vector3 spawnPoint;
	private bool alive = true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		spawnPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (alive) {
			transform.Rotate (Vector3.forward * -Input.GetAxis ("Horizontal"));
			if (Input.GetAxis ("Vertical") > 0)
				rb.AddForce (transform.up * 15 * Input.GetAxis ("Vertical"));
			Camera.main.transform.position -= new Vector3 (((Camera.main.transform.position.x - transform.position.x) / 10), ((Camera.main.transform.position.y - transform.position.y) / 10), 0);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground")
			StartCoroutine ("Death");
	}

	IEnumerator Death ()
	{
		alive = false;
		GetComponent<Renderer> ().enabled = false;
		yield return new WaitForSeconds(5f);
		if (lives > 0) {
			lives--;
			transform.position = spawnPoint;
			transform.rotation = Quaternion.identity;
			GetComponent<Renderer> ().enabled = true;
			alive = true;
		} else
			print ("Game Over");
	}
}
