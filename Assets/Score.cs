using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	public Text text;

	public void Increase () {

		score += 1;
        PlayerPrefs.SetInt("kills", score);
	}
	// Use this for initialization
	void Start () {

       score = PlayerPrefs.GetInt("kills");
    }
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Score:" + (score);
        

        

	}
}
