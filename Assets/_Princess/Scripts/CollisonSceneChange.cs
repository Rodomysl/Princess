using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisonSceneChange : MonoBehaviour {

	[SerializeField]
    
	private int loadScene = 0;
    public int spawnNum = 0;

    public Main mainScr;

    // Start is called before the first frame update
    void Start() 
	{
		
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider col) { 
		if (col.gameObject.tag == "Player")
		{
            //Debug.Log("Collision Detected It Works");
            //SceneManager.LoadScene(loadScene);
            
            mainScr.setSpawn(spawnNum);
            //mainScr.Save_Prefs();
            mainScr.Open_Scene(loadScene);

        }
    }

    


}