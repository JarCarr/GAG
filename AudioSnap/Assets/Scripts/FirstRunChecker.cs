using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_ANDROID
using UnityEngine.Android;
#elif UNITY_IOS
using UnityEngine.iOS;
#endif

public class FirstRunChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int firstRun = PlayerPrefs.GetInt("savedFirstRun");
        if (!PlayerPrefs.HasKey("FirstRun"))
        {
            PlayerPrefs.SetString("name", "[No Name Found]");
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene("Reg");
        }

#if UNITY_IOS
        if (!Application.HasUserAuthorization(UserAuthorization.WebCam)) {
             Application.RequestUserAuthorization(UserAuthorization.WebCam);
        }
#endif
#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera)) {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
