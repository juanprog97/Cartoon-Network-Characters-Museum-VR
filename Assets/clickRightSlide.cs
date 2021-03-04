using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickRightSlide : MonoBehaviour
{

    public clickRightVR interactiveObject;
    public uiProyect control;


    [System.Obsolete]

 
    void OnEnable()
    {
        interactiveObject.OnActionTrigger += clickRight;


    }

   [System.Obsolete]
    public void OnDisable()
    {

        interactiveObject.OnActionTrigger -= clickRight;
    }

    [System.Obsolete]
    private void clickRight()
    {
        control.Right();
    }
}
