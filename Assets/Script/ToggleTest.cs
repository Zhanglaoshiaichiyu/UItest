using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener((bool change) => ChangeValue(change));
            }

    private void ChangeValue(bool change)
    {
        Debug.Log("toggle changed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
