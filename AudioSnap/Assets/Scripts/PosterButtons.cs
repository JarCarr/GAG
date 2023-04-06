using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.SmartFormat.PersistentVariables;


public class PosterButtons : MonoBehaviour
{

    public int id;


    // Start is called before the first frame update
    void Start(Text obj)
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(GameObject obj){

        int tempid = obj.GetComponent<PosterButtons>().id;
        if(PosterScreen.values[tempid] == true) {
            Debug.Log("poster" + (tempid + 1) + "IS valid!");
        }
        else if(PosterScreen.values[tempid] == false) {
            Debug.Log("poster" + (tempid + 1) + " IS invalid! \n Value = " + PosterScreen.values[tempid]);
        }
        else{
            Debug.Log("Poster does not exist!");
        }
        Debug.Log(PlayerPrefs.GetString("values"));
    }

    private void addtext(string value, Text text){
        text.text = value;
    }
}
