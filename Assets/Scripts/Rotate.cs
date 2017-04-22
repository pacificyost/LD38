using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(100, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
