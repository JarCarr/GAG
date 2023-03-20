using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public string[] Languages = {"English", "French", "Chinese"};

    public Text buttontext;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void nextlang() {
        //get current language
        //if language is x, set language to y

        if (buttontext.text == "LANGUAGE:\nENGLISH")
        {
            buttontext.text = "LANGUAGE:\nFRENCH";
            //set language to french
        }
        else if (buttontext.text == "LANGUAGE:\nFRENCH")
        {
            buttontext.text = "LANGUAGE:\nCHINESE";
            //set language to chinese
        }
        else if (buttontext.text == "LANGUAGE:\nCHINESE")
        {
            buttontext.text = "LANGUAGE:\nENGLISH";
            //set language to english
        }

    }

}
