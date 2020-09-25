using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffector : MonoBehaviour
{
    
    // Start is called before the first frame update
    public AudioSource AudioSources;
    public AudioClip JumpSound;
    public AudioClip TreasureSound;
    public AudioClip LetterSound;
    public AudioClip RatSound;
    public AudioClip WalkSound;

    // Start is called before the first frame update
    void Start()
    {
        AudioSources.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     

    public void PlayJumpSound(){

        AudioSources.PlayOneShot(JumpSound);

    }

    public void PlayTreasureSound(){
        AudioSources.PlayOneShot(TreasureSound);
        
    }

    public void PlayLetterSound(){
       
        AudioSources.PlayOneShot(LetterSound, 1.0f);
        
    }

    public void PlayRatSound(){
        AudioSources.PlayOneShot(RatSound);
        
    }


}
