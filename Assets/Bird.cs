using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public GameObject poop;

	private Rigidbody2D rb;
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

			if (Input.GetButtonDown ("Poop")) {
				GameObject newDrop = (GameObject)Instantiate (poop, transform.position + (-Vector3.up * 0.5f), Quaternion.identity);
				Physics2D.IgnoreCollision (GetComponent<Collider2D> (), newDrop.GetComponent<Collider2D> ());
			}
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
		transform.position = spawnPoint;
		transform.rotation = Quaternion.identity;
		GetComponent<Renderer> ().enabled = true;
		alive = true;
	}
}
