using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    public Image image;
    public float restTime;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent < Image>();
    }

    // Update is called once per frame
    void Update()
    {

        if (restTime > 0)
        {
            restTime -= Time.deltaTime;
            image.fillAmount = restTime / cooldown;
        }
    }
}
