using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    private float objectSize;

	// Use this for initialization
	void Start () {
        objectSize = GetComponent<Renderer>().bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameManager.instance.player.transform.position.x > transform.position.x + objectSize*2f) {
            transform.position = new Vector3(transform.position.x + objectSize*3, transform.position.y, transform.position.z);
        }
        else if (GameManager.instance.player.transform.position.x < transform.position.x - objectSize * 2f) {
            transform.position = new Vector3(transform.position.x - objectSize * 3, transform.position.y, transform.position.z);
        }
    }
}
