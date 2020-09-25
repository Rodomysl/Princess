using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
 
    private Vector3 moveDirection = Vector3.zero;
    public GameObject player;
    public float turnSpeed = 180f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Animator girlAnim, animDragon, animTrans;
    private Animator _anim;
    private CharacterController _controller;

    public AudioSource FootstepsSource;
    public bool isDragon = false;
    
	
 
 
    // Start is called before the first frame update
    void Start()
    {
        //_anim = GetComponentInChildren<Animator>();
        _anim = animTrans;
        _controller = GetComponent<CharacterController>();
 
    }


    // Update is called once per frame
    void Update()
    {
        if(!isDragon){
          float input_x = Input.GetAxisRaw("Horizontal");
          float input_y = Input.GetAxisRaw("Vertical");
 
        if (_controller.isGrounded)
        {
 
           bool isRunning = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;
 
           _anim.SetBool("Run", isRunning);
     
            if(isRunning){
            //    Debug.Log("WalkingSound");
                PlayWalkSound();
            }
                else StopWalkSound();

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            /*
			if (Input.anyKey)
			{
				player.transform.rotation = Quaternion.RotateTowards(player.transform.rotation, Quaternion.LookRotation(moveDirection), turnSpeed * Time.deltaTime);        

			}*/
            // some fix
            if (moveDirection != Vector3.zero)
			{
				player.transform.rotation = Quaternion.RotateTowards(player.transform.rotation, Quaternion.LookRotation(moveDirection), turnSpeed * Time.deltaTime);        
			}

            moveDirection *= _speed;
            if (Input.GetButton("Jump"))
			{
				_anim.SetTrigger("Jump");
                moveDirection.y = jumpSpeed;
			}

            //    Debug.Log(isRunning);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        _controller.Move(moveDirection * Time.deltaTime);
        }

    }

    public void setMutation(){
        Debug.Log("Mutation");
        isDragon = true;
        _anim = animTrans;
        _anim.SetTrigger("Mutation");


    }
	
       public void PlayWalkSound(){ 
        FootstepsSource.enabled = true;
        }

         IEnumerator Waiting(float time)
         {
             yield return new WaitForSeconds(time);
             FootstepsSource.enabled = false;
         }
  
        public void StopWalkSound(){
           StartCoroutine(Waiting(0.2f));
    }


 
}