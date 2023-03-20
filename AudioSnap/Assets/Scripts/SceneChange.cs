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

    public void goto_scan() {
        changeRoom("Scan");
        return;
    }
    public void goto_posters() {
        changeRoom("Posters_main");
        return;
    }

    public void goto_leaderboard() {
        changeRoom("Leaderboard");
        return;
    }


    public void goto_info() {
        changeRoom("Info");
        return;
    }
    public void goto_map() {
        changeRoom("Map");
        return;
    }
    public void goto_settings() {
        changeRoom("Settings");
        return;
    }
    public void back()
    {
        changeRoom("Main_menu");
        return;
    }

    void changeRoom(string roomname){
        string lastrm = currentrm;
        SceneManager.LoadScene(roomname);
        currentrm = roomname;
        return;
    }
}


//going back: current room is last room, last room is current room, change room