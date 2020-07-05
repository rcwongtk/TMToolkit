using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDropdownExpand : MonoBehaviour
{
    private GameObject parentObject;
    private Vector2 originalHeight;

    // Start is called before the first frame update
    void Start()
    {
        // At the start, store our original height of the dropdown menu
        parentObject = gameObject.transform.parent.gameObject;
        originalHeight = parentObject.GetComponent<RectTransform>().sizeDelta;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Expands the size of the object to accomodate the dropdown menu
    public void dropDownSelected()
    {

        // Confirm height of dropdown object has already been changed
        // If it has been (i.e. it has grown) shrink it down. But if it hasn't expand it
        if(parentObject.GetComponent<RectTransform>().sizeDelta.y == originalHeight.y)
        {
            // If the height is the original height, Expand the dropdown
            parentObject.GetComponent<RectTransform>().sizeDelta = new Vector2(parentObject.GetComponent<RectTransform>().sizeDelta.x, parentObject.GetComponent<RectTransform>().sizeDelta.y * 3.5f);
        }
        else
        {
            //If the height is the stretched height, Collapse the dropdown
            parentObject.GetComponent<RectTransform>().sizeDelta = new Vector2(parentObject.GetComponent<RectTransform>().sizeDelta.x, originalHeight.y);
        }

    }

    // Returns dropdown menu object back to it's original size when an item is selected
    public void dropDownItemSelected()
    {
        parentObject.GetComponent<RectTransform>().sizeDelta = new Vector2(parentObject.GetComponent<RectTransform>().sizeDelta.x, originalHeight.y);
    }
}
