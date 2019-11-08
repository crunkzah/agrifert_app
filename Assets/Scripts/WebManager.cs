using UnityEngine;

public class WebManager : MonoBehaviour
{

    static WebManager _instance;
    public static WebManager singleton
    {
        get
        {
            if(_instance == null)
                _instance = FindObjectOfType<WebManager>();
            return _instance;
        }
    }

    //TODO
    void Awake()
    {
#if UNITY_EDITOR || UNITY_STANDALONE_WIN
        Application.targetFrameRate = 120;
#endif

#if UNITY_IOS || UNITY_ANDROID
        Application.targetFrameRate = 60;
#endif
    }

    public void OpenMainWebsite()
    {
        Application.OpenURL("http://agrifert.ru");
    }
    public string filename = "";
    public TextAsset pdf_text_asset;
    public void OpenPDF()
     {
         string path = System.IO.Path.Combine(Application.persistentDataPath, filename + ".pdf");
 
         TextAsset pdfTemp = Resources.Load(filename, typeof(TextAsset)) as TextAsset;
         pdf_text_asset = pdfTemp;
        
        
 
         System.IO.File.WriteAllBytes(path, pdfTemp.bytes);
 
         Application.OpenURL(path);
     }

    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/agri_fert/");
    }


    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    
}
