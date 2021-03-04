using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickLeftSlide : MonoBehaviour
{

    public clickLeftVr interactiveObject;
    public uiProyect control;
    public Text Debug;

    [System.Obsolete]
    public void OnEnable()
    {
        interactiveObject.OnActionTrigger += clickLeft;

    }

    [System.Obsolete]
    public void OnDisable()
    {
        interactiveObject.OnActionTrigger -= clickLeft;
    }

    [System.Obsolete]
    public void clickLeft()
    {
        control.Left();
    }
}
