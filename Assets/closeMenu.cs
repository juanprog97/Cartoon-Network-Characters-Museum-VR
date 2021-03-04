using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeMenu : MonoBehaviour
{
    public GameObject MainMenu;

    [System.Obsolete]
    void OnEnable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger += clickCloseMenu;

    }

    [System.Obsolete]
    private void OnDisable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger -= clickCloseMenu;
    }

    [System.Obsolete]
    private void clickCloseMenu()
    {
        MainMenu.SetActive(!MainMenu.active);
    }

}
