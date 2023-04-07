using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterScreen : MonoBehaviour
{
    public static char[] values;
    // Start is called before the first frame update
    void Start()
    {
        values = PlayerPrefs.GetString("values").ToCharArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
