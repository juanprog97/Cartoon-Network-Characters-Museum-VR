using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvController : MonoBehaviour
{
    public GameObject tvObject;
    private List<string> Animation;
    private float timer = 0.0f;
    private float waitTime = 2.0f;
    private int cont = 0; 

    

    void Start()
    {
        this.Animation = new List<string>()
        {
          "To_Courage","To_cow","To_Dexter","To_Ed","To_Hannah","To_Jhony","To_knd","To_powerGirl","To_Samurai"
          ,"To_Squad","To_weasel","To_Billy"
        };
        this.tvObject.GetComponent<Animator>().Play(Animation[cont]);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            
            cont = cont == this.Animation.Count-1 ? 0 : cont+1;
            Debug.Log(cont);
            this.tvObject.GetComponent<Animator>().Play(Animation[cont]);
            timer = timer - waitTime;
         
        }
    }
}
