using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterScreen : MonoBehaviour
{
    public static char[] values;

    // Start is called before the first frame update
    void Start()
    {
        values = PlayerPrefs.GetString("values").ToCharArray();

        GameObject go = GameObject.Find("Container");

        for (int i = 0; i < go.transform.childCount; i++)
        {
            if(PlayerPrefs.GetString("values")[i] == '0')
            {
                go.transform.GetChild(i).GetComponent<Text>().color = Color.red;
            }
            else
            {
                go.transform.GetChild(i).GetComponent<Text>().color = Color.green;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
