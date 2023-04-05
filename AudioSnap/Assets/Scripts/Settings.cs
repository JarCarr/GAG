using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Settings : MonoBehaviour
{
    //public string[] Languages = {"English", "French", "Chinese"};

    //public string language = PlayerPrefs.GetString("lang");

    
    // Start is called before the first frame update
    void Start()
    {
    }


    public void nextlang() {
 


        
        if (PlayerPrefs.GetString("lang") == "English")
        {
           PlayerPrefs.SetString("lang", "Spanish");
           LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
           //sprite.sprite = spn;
          
        }

        else if (PlayerPrefs.GetString("lang") == "Spanish")
        {
            PlayerPrefs.SetString("lang", "Italian");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[2];
            //sprite.sprite = ital;
            
        }

        else if (PlayerPrefs.GetString("lang") == "Italian")
        {
            PlayerPrefs.SetString("lang", "French");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[3];
            //sprite.sprite = fr;
            
        }

        else if (PlayerPrefs.GetString("lang") == "French")
        {
            PlayerPrefs.SetString("lang", "German");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[4];
           //sprite.sprite = ger;
            
        }

        else if (PlayerPrefs.GetString("lang") == "German")
        {
            PlayerPrefs.SetString("lang", "Japanese");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[5];
            //sprite.sprite = jpn;
            
        }
                else if (PlayerPrefs.GetString("lang") == "Japanese")
        {
            PlayerPrefs.SetString("lang", "Portugese");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[6];
            //sprite.sprite = jpn;
            
        }

        else if (PlayerPrefs.GetString("lang") == "Portugese")
        {
            PlayerPrefs.SetString("lang", "English");
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
            //sprite.sprite = eng;
            
        }
        

    }

    public void PrintLang() {
        Debug.Log(PlayerPrefs.GetString("lang"));
    }





}