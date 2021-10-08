using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalLanguage : MonoBehaviour
{
    public static string currentLanguage = "Español";
    public Toggle toggleEs;
    public Toggle toggleEn;
    public bool MenuScene;
    // Start is called before the first frame update
    private void Awake()
    {
       // DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        changeLanguage(currentLanguage);
    }
    public string returnLanguage()
    {
        return (currentLanguage);
    }
     public void changeLanguage(string language1)
    {
        print(language1);
        currentLanguage = language1;
        NotificationCenter.DefaultCenter().PostNotification(this,"ChangeLanguage_");
        if (MenuScene)
        {
            if (language1 == "Español")
            {
                toggleEs.isOn = true;
            }
            else if (language1 == "English")
            {
                toggleEn.isOn = true;
            }
        }
       
    }
}
