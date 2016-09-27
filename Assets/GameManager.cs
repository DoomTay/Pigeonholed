using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject player;//Player reference
    public ScoreManager scoreManage;

    void Awake() {
        //Check if instance already exists
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        RestartWithR();
        ChkNulls();
    }

    void ChkNulls() {
        if (player == null) {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if (scoreManage == null) {
            scoreManage = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        }
    }

    //Restart with R
    void RestartWithR() {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
