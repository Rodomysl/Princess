using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{

    public GameObject[] spawnPoints;
    static private int spawnNum = 0;
    public TMP_Text crowns;
    public GameObject PauseScreen, spawnPoint, Player;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, spawnPoints[spawnNum].transform.position, new Quaternion(0.0f, 0.0f,0.0f,0.0f));
        
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
        
        SceneManager.LoadScene(index);
        
    }


    


    private void Save_Prefs(){
     
        if(PlayerPrefs.HasKey("Crowns")) // проверяем ключ
        {
            PlayerPrefs.SetInt("Crowns", int.Parse(crowns.text));
        }
        else PlayerPrefs.SetInt("Crowns", 0);
    
    }




}
