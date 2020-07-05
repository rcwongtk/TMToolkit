using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickToLink : MonoBehaviour
{

    string websiteLink;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Take the text weblink and go to that page
    public void OpenLink()
    {
        websiteLink = gameObject.GetComponent<TextMeshProUGUI>().text;
        Application.OpenURL(websiteLink);
    }
}
