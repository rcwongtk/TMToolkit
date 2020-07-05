using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerStopWatch : MonoBehaviour
{

    public float timer;
    public bool timeStarted = false;
    private GameObject parentObject;
    private GameObject startButton;
    private GameObject pauseButton;
    private bool lockActivated = false;
    private float min = 0;
    private float mid = 0;
    private float max = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        // Start by finding the parent object
        parentObject = gameObject.transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if the timeStarted is true, and if so, execute the timer
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }

        // If timer hits the min, mid, or max times, change the background to a different color.
        if(min > 0)
        {
            if (timer < min)
            {
                parentObject.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            }
            else if (timer > min && timer < mid)
            {
                parentObject.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
            }
            else if (timer > mid && timer < max)
            {
                parentObject.GetComponent<Image>().color = new Color32(255, 255, 0, 100);
            }
            else if (timer > max)
            {
                parentObject.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
            }
        }

        

        // Convert the timer value to minutes and seconds, then display
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        gameObject.GetComponent<TextMeshProUGUI>().text = minutes + ":" + seconds;

    }

    // Simple method, if called then just toggle the boolean to true, starting the timer
    public void StartTimer()
    {
        
        timeStarted = true;
    }

    // If called, stop the timer by changing timeStarted to false
    public void PauseTimer()
    {
        
        timeStarted = false;
    }

    //To lock the timer, hide the start/pause button
    public void LockTimer()
    {

        // We first take the parent, and then find the start and pause button objects
        startButton = parentObject.transform.Find("startButton").gameObject;
        pauseButton = parentObject.transform.Find("pauseButton").gameObject;

        // Create a toggle to activte or deactivate the gameobject depending
        if(lockActivated == false)
        {
            startButton.SetActive(false);
            pauseButton.SetActive(false);
            timeStarted = false;
            lockActivated = true;
        }
        else if(lockActivated == true)
        {
            startButton.SetActive(true);
            pauseButton.SetActive(false);
            lockActivated = false;
        }
        else
        {
            Debug.Log("Issue with Locking System");
        }
        
    }

    // Prepared Speeches are 5-7 minutes
    public void PreparedSpeech()
    {
        min = 5 * 60;
        mid = 6 * 60;
        max = 7 * 60;
    }

    // Table Topics are 1-2 minutes
    public void TTSpeaker()
    {
        min = 1 * 60;
        mid = 1.5f * 60;
        max = 2 * 60;
    }

    // Evaluations are 2-3 minutes
    public void Evaluations()
    {
        min = 2 * 60;
        mid = 2.5f * 60;
        max = 3 * 60;
    }

    // Icebreakers are 4-6 minutes
    public void IceBreaker()
    {
        min = 4 * 60;
        mid = 5 * 60;
        max = 6 * 60;
    }

}
