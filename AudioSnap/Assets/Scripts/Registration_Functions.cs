using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Registration_Functions : MonoBehaviour
{

    public Text errortext;
    //private string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ValidName(string name){
        if (name == "" || name.Contains(" "))
        {
            return false;
        }
        return true;
    }

    //Name Register Function for the Registration screen
    public void Register(InputField namebox) {
        if(ValidName(namebox.text)) {
            PlayerPrefs.SetString("name", namebox.text);
            Debug.Log(PlayerPrefs.GetString("name"));
            PlayerPrefs.SetInt("score", 0);
            PlayerPrefs.SetString("values", "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            PlayerPrefs.SetInt("FirstRun", 0);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Main_menu");
        }
    }
}
