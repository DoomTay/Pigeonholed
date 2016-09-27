using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour {

    public float speed = 5f;
    public GameObject bread;
    Rigidbody2D rb;
 

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        speed = Random.Range(0, 2) == 0 ? -speed : speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = new Vector2(speed, rb.velocity.y);
	}


    void SpawnBread() {
        Instantiate(bread, transform.position, Quaternion.identity);
    }
}
