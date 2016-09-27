using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float distanceX;
    public GameObject people;
    public float spawnTimer = 2f;

    float timePassed = 0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(GameManager.instance.player.transform.position.x + distanceX, 
            transform.position.y, GameManager.instance.player.transform.position.z);


        timePassed += Time.deltaTime;

        if (timePassed >= spawnTimer) {

            Instantiate(people, transform.position, Quaternion.identity);
            timePassed = 0f;
        }
    }
}
