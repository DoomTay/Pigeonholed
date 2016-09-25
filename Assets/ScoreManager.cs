using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddBread(int breadVal) {
        score += breadVal;
    }

}
