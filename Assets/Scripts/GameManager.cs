using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float startTime = 10f;
    public float minPercent = 0.2f;
    public static float currentTime = 10f;
    public static float percent = 1f;
    private static float bonusTime = 0f;
    

	// Use this for initialization
	void Awake () {
        currentTime = startTime;
        bonusTime = 0f;
        CalcPercent();
    }
	
	// Update is called once per frame
	void Update () {
        if (bonusTime <= 0)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
            }
        }
        else
        {
            currentTime += Time.deltaTime;
            bonusTime -= Time.deltaTime;
        }
        CalcPercent();

    }

    private void CalcPercent()
    {
        if (currentTime > 0)
        {
            percent = (currentTime + (startTime * minPercent)) / startTime;
        }
        else
        {
            percent = minPercent;
        }

    }

    public static void AddTime(float time)
    {
        bonusTime += time;
    }
}
