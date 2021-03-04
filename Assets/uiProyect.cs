using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class uiProyect : MonoBehaviour
{
    public class Info
    {
        public int img { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
    }
    private  listInfo ol;
    public class listInfo
    {
        public  List<Info> info { get; set; }
    }
    
    private static int numInfo = 0;
    public GameObject Menu;
    public GameObject Information;
    private List<Sprite> spritesCharacter;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;
    public Sprite image7;
    public Sprite image8;
    public Sprite image9;
    public Sprite image10;
    public Sprite image11;
    public Sprite image12;
    private string jsonPath;

    private IEnumerator coroutine;





    [System.Obsolete]
    private void OnEnable()
    {
        jsonPath = "jar:file://" + Application.dataPath + "!/assets/info.json";
        coroutine = uploadInformation();
        StartCoroutine(coroutine);
    }

    [System.Obsolete]
    IEnumerator uploadInformation()
    {
        UnityWebRequest www = UnityWebRequest.Get(jsonPath);
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            // EditorUtility.DisplayDialog("Response", "Error", "Ok");
            //     debug.GetComponent<Text>().text =  "ERROR";
            Debug.Log("Error Downloaded");
      
        }
        else
        {

            //  debug.GetComponent<Text>().text = "Ok";
            try
            {

                ol =  JsonConvert.DeserializeObject<listInfo>(www.downloadHandler.text);
                //   debug.GetComponent<Text>().text = DatosRanking.Songs.Count.ToString();
                spritesCharacter = new List<Sprite> { image1 , image2 , image3 , image4 , image5 , image6 , image7 ,
                image8 , image9 , image10 , image11 , image12 };
                updateShow();


            }
            catch
            {
                // debug.GetComponent<Text>().text = "Error Try";
          
            }


        }
       
}

    [System.Obsolete]
    public void Right()
    {
    
        try
        {
            numInfo = numInfo == ol.info.Count-1 ? 0 : numInfo + 1;
            updateShow();
        }
        catch
        {
            Debug.Log("Error");
        }
     
    }

    [System.Obsolete]
    public void Left()
    {
        try
        {
            numInfo = numInfo == 0 ? ol.info.Count - 1 : numInfo - 1;
            updateShow();
        }
        catch
        {
            Debug.Log("No working");
        }
        
    }



    [System.Obsolete]
    private void updateShow()
    {
        Image imageCharacter = Information.transform.FindChild("Image").GetComponent<Image>();
        Text titleCharacter = Information.transform.FindChild("title").GetComponent<Text>();
        Text descriptionCharacter = Information.transform.FindChild("information").GetComponent<Text>();

        imageCharacter.sprite = spritesCharacter[ol.info[numInfo].img];
        titleCharacter.text = ol.info[numInfo].title;
        descriptionCharacter.text = ol.info[numInfo].desc;
        

    }


}
