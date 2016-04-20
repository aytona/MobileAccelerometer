using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerCount : MonoBehaviour {
    public Text timerText;
    public GameObject loseOverlay;
    private float timeLeft;

	// Use this for initialization
	void Start () {
        loseOverlay.SetActive(false);
        timeLeft = 300.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time Left: " + (int)timeLeft;
        if(timeLeft <= 0)
        {
            //Trigger lose state
            Time.timeScale = 0;
            loseOverlay.SetActive(true);
        }
	}
}
