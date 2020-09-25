using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{
    private Animator animator;
    private bool isFirstTime = true;
    public UI ui;
    public PlayerMovement player;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isFirstGet()
    {
        return isFirstTime;
    }
    public bool isAllCrown()
    {
        return ui.getCrown() == 6;
    }

    public void show()
    {
        if (isFirstTime && ui.getCrown() < 6){
            animator.SetTrigger("DoorFirst");
            isFirstTime = false;
        }
        else if(ui.getCrown() < 6)
            animator.SetTrigger("DoorMore");
        else if(ui.getCrown() == 6)
        {
            animator.SetTrigger("DoorFinish");
            StartCoroutine(Waiting());
        }
            
    }


    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(3.0f);
        player.setMutation();
    }
}
