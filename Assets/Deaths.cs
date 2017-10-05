using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour {

	public int deaths = 0;
	public Text text;

	public void Increase(){
		deaths += 1;
        PlayerPrefs.SetInt("Deaths", deaths);
    }
	// Use this for initialization
	void Start () {
        deaths = PlayerPrefs.GetInt("Deaths");
    }
	// Update is called once per frame
	void Update () {
		text.text = "Deaths:" + (deaths);
	}
}
