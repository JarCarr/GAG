using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameshow : MonoBehaviour
{
    [SerializeField] public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = PlayerPrefs.GetString("name");
        text.text += ": " + PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = PlayerPrefs.GetString("Name");
    }

    public void showstring(){
        Debug.Log(PlayerPrefs.GetString("name"));
    }
}
