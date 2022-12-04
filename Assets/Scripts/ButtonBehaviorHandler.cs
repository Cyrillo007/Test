using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviorHandler : MonoBehaviour
{

    public GameObject button;

    public void OnclickHandlerButton1()
    {
        button.SetActive(false);
    }

    public void OnclickHandlerButon2()
    {
        button.SetActive(true);
    }
}
