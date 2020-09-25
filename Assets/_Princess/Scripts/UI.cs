﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{

    
    public SoundEffector sounds;
    public TMP_Text Pages, pageNum, crownCounter;
    public GameObject Panel;
    public Main main;
    private int currPage = 1, maxPages, crownCount;
    private Treasure currTreasure;

    public void setCrown(int count){
       // Debug.Log(count + "crowcount");
        //Debug.Log(crownCounter.text);
        
        crownCount = count;
        crownCounter.text = crownCount.ToString();
    }

    public int getCrown(){
        return crownCount;
    }

    public void setTreasure(Treasure treasure){
        currTreasure = treasure;
    }

    private void Start() {
        //crownCounter.text = crownCount.ToString();
        //Debug.Log(crownCounter.text +"start");
        if(PlayerPrefs.HasKey("Crowns")) // проверяем ключ
        {
            crownCount = PlayerPrefs.GetInt("Crowns");
        }
        else crownCount = 0;
        setCrown(crownCount);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(crownCount + "update");
    }

    public void SetPages(int pagesCount, string text) //enter text
    {
        
        currTreasure.animator.SetBool ("OpenLetter", true);
        sounds.PlayLetterSound();
        //Panel.SetActive(true);
        Pages.text = text;
        currPage = 1;
        Pages.pageToDisplay = currPage;
        maxPages = pagesCount;
        pageNum.text = $"{currPage} of {maxPages}";
        
    }

    public void SwipePages()
    {
        if(currPage == maxPages){
            currTreasure.animator.SetBool ("OpenLetter", false);
        }
        Debug.Log("SwipePages");
        currPage += 1;
        Pages.pageToDisplay = currPage;
        pageNum.text = $"{currPage} of {maxPages}";
    }

}
