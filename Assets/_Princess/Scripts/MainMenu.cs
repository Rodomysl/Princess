using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject Settings, MainPanel;


    // Start is called before the first frame update
    void Start()
    {/*
         if(!PlayerPrefs.HasKey("EffectsVolume"))
        {
            PlayerPrefs.SetFloat("EffectsVolume", 5f) ;
        }
         if(!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 5f) ;
        }
            MusicSlider.value =  PlayerPrefs.GetFloat("MusicVolume") ;
            EffectsSlider.value =  PlayerPrefs.GetFloat("EffectsVolume") ;
            EffectsVolume.text = PlayerPrefs.GetFloat("EffectsVolume").ToString();
            MusicVolume.text = PlayerPrefs.GetFloat("MusicVolume").ToString();
*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        Application.Quit();
    }

     public void Open_Scene(int index ){
        
        SceneManager.LoadScene(index);
        
    }
}
