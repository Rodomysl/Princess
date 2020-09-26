using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{

    public GameObject[] spawnPoints;
    static private int spawnNum = 0;
    public UI ui;
    public GameObject PauseScreen, Player;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, spawnPoints[spawnNum].transform.position, new Quaternion(0.0f, 0.0f,0.0f,0.0f));
        Player.SetActive(true);
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape) && Time.timeScale == 0f)
        {
            PauseOff();
        }
        else if(Input.GetKeyUp(KeyCode.Escape) && Time.timeScale == 1f)
        {
            PauseOn();
        }

    }

    public void setSpawn(int number){
        spawnNum = number;
    }

    public void PauseOn(){
        PauseScreen.SetActive(true);
        Time.timeScale = 0f; // пауза в игре
    }

    public void PauseOff(){
        PauseScreen.SetActive(false); 
        Time.timeScale = 1f; // возобновляем ход времени  
    }


    public void Open_Scene(int index ){
        
        Save_Prefs();
        SceneManager.LoadScene(index);
        
    }

    public void Save_Prefs(){

        Debug.Log("Save!" + ui.getCrown());
         Debug.Log( PlayerPrefs.GetInt("Crowns"));

        PlayerPrefs.HasKey("Crowns");
        PlayerPrefs.SetInt("Crowns", ui.getCrown());
        /*if(PlayerPrefs.HasKey("Crowns")) // проверяем ключ
        {
            PlayerPrefs.SetInt("Crowns", ui.getCrown());
        }
        else PlayerPrefs.SetInt("Crowns", 0);*/
    
    }




}
