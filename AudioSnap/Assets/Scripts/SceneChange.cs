using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    public string lastrm;
    public string currentrm;

    // Start is called before the first frame update
    void Start()
    {
  
    }
    public void back()
    {
        changeRoom("Main_menu");
        return;
    }

    public void changeRoom(string roomname){
        SceneManager.LoadScene(roomname);
        return;
    }
}


//going back: current room is last room, last room is current room, change room