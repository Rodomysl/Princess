using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Treasure : Interactable {


	public UI UI;
	public int pageCount; 
	Animator animator;

	bool isOpen;
	public Item[] items;
	public Text letter;
	

	void Start() {
		animator = GetComponent<Animator> ();
	}

	public override void Interact ()
	{
		//base.Interact ();
		if (!isOpen) {
			//animator.SetTrigger ("Open");
			StartCoroutine (CollectTreasure ());
		}
	}

	IEnumerator CollectTreasure() {

		isOpen = true;
		

		

		yield return new WaitForSeconds (1f);
		print ("Chest opened");
	/*	foreach (Item i in items) {
			Inventory.instance.Add (i);
		}*/
		yield return new WaitForSeconds (2f);
		UI.SetPages(pageCount, letter.text);

		

	}




}


