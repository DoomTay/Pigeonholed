using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ScoreManager : MonoBehaviour {

    public int score;
    public Text scoreUI;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreUI.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        scoreUI.text = "Score: " + score.ToString();
    }

    public void AddBread(int breadVal) {
        score += breadVal;
    }

}
