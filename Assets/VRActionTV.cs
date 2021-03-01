using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VRActionTV : MonoBehaviour
{
    public GameObject m_TvImage;
    public GameObject light_AreaLight;
    public GameObject m_videoTv;

    [Obsolete]
    void OnEnable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger += changeStateTV;
      
    }

    [Obsolete]
    private void changeStateTV()
    {
        VideoPlayer var_videoTv = m_videoTv.GetComponent<VideoPlayer>();
        m_TvImage.active = !m_TvImage.active;
        light_AreaLight.active = !light_AreaLight.active;

        var_videoTv.SetDirectAudioMute(0, !var_videoTv.GetDirectAudioMute(0));
    }

    // Update is called once per frame

}
