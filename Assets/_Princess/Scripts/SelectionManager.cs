using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
	[SerializeField] private string selectableTag = "Interactable";
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//var selectionRenderer.enabled == false;
		
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			var selection = hit.transform;
			if (selection.CompareTag(selectableTag))
			{
				Debug.Log(selection);
				var selectionRenderer = selection.GetComponent<Outline>();
				Debug.Log(selectionRenderer);
				
				if (selectionRenderer != null)
				{
					selectionRenderer.enabled = !selectionRenderer.enabled;
				}
			}
			
		}
		
		
    }
}
