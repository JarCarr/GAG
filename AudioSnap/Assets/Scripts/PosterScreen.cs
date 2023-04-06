using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterScreen : MonoBehaviour
{
    public static bool[] values;
    // Start is called before the first frame update
    void Start()
    {
        values = ArrayHandler.TextToNumArray(PlayerPrefs.GetString("values"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
