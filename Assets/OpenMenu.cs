using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject MainMenu;

    [System.Obsolete]
    void OnEnable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger += clickOpenMenu;

    }

    [System.Obsolete]
    private void OnDisable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger -= clickOpenMenu;
    }

    [System.Obsolete]
    private void clickOpenMenu()
    {
        MainMenu.SetActive(!MainMenu.active);
    }
}
