using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject winImage;
    public GameObject loseImage;
    //for now, we'll only control winning or losing here.
    //in the future, you can add a score count here, a timer,
    //high scores,etc.
    public int count = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void lose(){
        loseImage.SetActive(true);
        Time.timeScale = 0;
    }
    public void win(){
        winImage.SetActive(true);
        Time.timeScale = 0;
    }
}
