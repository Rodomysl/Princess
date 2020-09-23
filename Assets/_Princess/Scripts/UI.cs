using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{


    private int currPage = 1;
    public TMP_Text Pages, pageNum;
    public GameObject Panel;
    private int maxPages;


    private void Start() {

        
       
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPages(int pagesCount, string text) //enter text
    {
        Panel.SetActive(true);
        Pages.text = text;
        currPage = 1;
        Pages.pageToDisplay = currPage;
        maxPages = pagesCount;
        
    }

    public void SwipePages()
    {
        if(currPage == maxPages){
            Panel.SetActive(false);
        }
        currPage += 1;
        Pages.pageToDisplay = currPage;
        pageNum.text = $"{currPage} of {maxPages}";
    }

}
