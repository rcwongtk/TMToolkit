using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class AhCounterScript : MonoBehaviour
{

    public int clickCounter;
    private TextMeshProUGUI textObject;
    private string baseContent;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Trigger when plus button pressed. Increase counter value
    public void clickCounterPlus()
    {
        clickCounter++;
        UpdateText();
    }

    // Trigger when minus button pressed. Decrease counter value
    public void clickCounterMinus()
    {
        if(clickCounter <= 0)
        {

        } else
        {
            clickCounter--;
            UpdateText();
        }
    }

    // Update the Counter. Gets the text, and then updates the number
    private void UpdateText()
    {
        textObject = gameObject.GetComponent<TextMeshProUGUI>();
        int index = textObject.text.IndexOf(":");
        baseContent = textObject.text.Substring(0, index);
        textObject.text = baseContent + ":  " + clickCounter;
    }

}
