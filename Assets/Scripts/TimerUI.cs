using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "test";
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Mathf.Abs(GameManager.currentTime).ToString("00.00");
	}
}
