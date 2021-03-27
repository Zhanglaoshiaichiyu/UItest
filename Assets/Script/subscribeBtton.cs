using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subscribeBtton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(OnButtonClick);
        String str = "str";
        //委托按钮
        this.gameObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClickParameter(str));
    }

    private void OnButtonClick()
    {
        Debug.Log("Click");
    }

    private void OnButtonClickParameter(string str)
    {
        Debug.Log(str);

    }
}
