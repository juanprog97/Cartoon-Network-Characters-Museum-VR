using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class TvController : MonoBehaviour
{
    public GameObject tvObject;
    private List<string> Animation;
    private List<float> durationVideo;
    private float timer = 0.0f;
    private float waitTime;
    private int cont = 0;
    public VideoPlayer videoClipCartoon;
    public VideoClip Courage;
    public VideoClip Cow;
    public VideoClip Dexter;
    public VideoClip Ed;
    public VideoClip Hannah;
    public VideoClip Johnny;
    public VideoClip Knd;
    public VideoClip Power;
    public VideoClip Samurai;
    public VideoClip Squad;
    public VideoClip Weasel;
    public VideoClip Billy;



  
    void Start()
    {

        


        Animation = new List<string>()
        {
          "To_Courage","To_cow","To_Dexter","To_Ed","To_Hannah","To_Jhony","To_knd","To_powerGirl","To_Samurai"
          ,"To_Squad","To_weasel","To_Billy"
        };

        durationVideo = new List<float>()
        {
            30.0f, 32.0f, 31.0f, 32.0f, 11.0f, 32.0f, 33.0f, 63.0f, 78.0f, 21.0f, 41.0f, 31.0f
        };

        this.waitTime = this.durationVideo[cont];
        StartCoroutine(OnCompleteAnimation());

    }

    IEnumerator OnCompleteAnimation()
    {
        this.tvObject.GetComponent<Animator>().Play(Animation[cont]);
        yield return new WaitForSeconds(1.0f);
        putVideo(cont);
       

        // TODO: Do something when animation did complete
    }



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            videoClipCartoon.clip = null;
            cont = cont == this.Animation.Count-1 ? 0 : cont+1;
            
            timer = timer - waitTime;
            this.waitTime = this.durationVideo[cont];
            StartCoroutine(OnCompleteAnimation());
        }
    }


    void putVideo(int cont)
    {
        switch (cont)
        {
            case 0:
                videoClipCartoon.clip = Courage;
                break;
            case 1:
                videoClipCartoon.clip = Cow;
                break;
            case 2:
                videoClipCartoon.clip = Dexter;
                break;
            case 3:
                videoClipCartoon.clip = Ed;
                break;
            case 4:
                videoClipCartoon.clip = Hannah;
                break;
            case 5:
                videoClipCartoon.clip = Johnny;
                break;
            case 6:
                videoClipCartoon.clip = Knd;
                break;
            case 7:
                videoClipCartoon.clip = Power;
                break;
            case 8:
                videoClipCartoon.clip = Samurai;
                break;
            case 9:
                videoClipCartoon.clip = Squad;
                break;
            case 10:
                videoClipCartoon.clip = Weasel;
                break;
            case 11:
                videoClipCartoon.clip = Billy;
                break;
        }
        videoClipCartoon.Play();

    }
}
