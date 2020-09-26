using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator> ();
        animator.SetTrigger("Mutation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
