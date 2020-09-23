using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisonSceneChange : MonoBehaviour {

	[SerializeField]
	private int loadScene = 0;

    // Start is called before the first frame update
    void Start() 
	{
		
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider col) { 
		if (col.gameObject.name == "Character")
		{
            //Debug.Log("Collision Detected It Works");
            SceneManager.LoadScene(loadScene);
        }
    }

}