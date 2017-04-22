using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleByTime : MonoBehaviour {

    private Vector3 initialScale;

	// Use this for initialization
	void Awake () {
        initialScale = transform.localScale;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameManager.percent > 0)
        {
            transform.localScale = new Vector3(initialScale.x * GameManager.percent, initialScale.y * GameManager.percent, initialScale.z * GameManager.percent);
        }
    }
}
