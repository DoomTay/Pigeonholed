using UnityEngine;
using System.Collections;

public class Bread : MonoBehaviour {

    public int breadValue;

  

	void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            GameManager.instance.scoreManage.AddBread(breadValue);
            Destroy(gameObject);
        }
    }
}
