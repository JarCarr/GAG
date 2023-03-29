using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstRunChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int firstRun = PlayerPrefs.GetInt("savedFirstRun");
        if (!PlayerPrefs.HasKey("FirstRun"))
        {
            PlayerPrefs.SetString("Name", "");
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene("Reg");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
