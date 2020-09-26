using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject Credits, MainPanel;
    private bool credintActive = false;


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

    public void SetCredits()
    {
        if (credintActive == true)
        {
                Credits.SetActive(false);
                credintActive = false;
        }
        else 
        {
            credintActive = true;
            Credits.SetActive(true);
        }
    }


    public void Close()
    {
        Application.Quit();
    }

     public void Open_Scene(int index ){       
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(index);
        
    }

    public void SwipePages()
    {
        /*if(currPage == maxPages){
            ;
        }
        Debug.Log("SwipePages");
        currPage += 1;
        Pages.pageToDisplay = currPage;
        pageNum.text = $"{currPage} of {maxPages}";*/
    }
}
