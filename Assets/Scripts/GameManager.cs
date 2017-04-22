using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float startTime = 10f;
    public static float currentTime = 10f;
    public static float percent = 1f;
    private static float bonusTime = 0f;

	// Use this for initialization
	void Awake () {
        currentTime = startTime;
        bonusTime = 0f;
        percent = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (bonusTime <= 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            currentTime += Time.deltaTime;
            bonusTime -= Time.deltaTime;
        }
        percent = currentTime / startTime;
	}

    public static void AddTime(float time)
    {
        bonusTime += time;
    }
}
