using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveIt : MonoBehaviour
{
    TheControls controls;
    public float moveSpeed;
    public float sprintMultiplier;
    public Rigidbody rb;
    private Vector3 moveInput;
    public KeyCode KeyboardSprint;

    private float activeMoveSpeed;
    public speedometer speeeeed;
    //public Animator animator;

    private void Awake()
    {
        //For now, assigns the controls
        controls = new TheControls();
        controls.GamePlay.Interact.performed += ctx => Interact();
    }
    void Interact()
    {
        //put interact functions here
        Console.WriteLine("lesgoooooooooo");
    }
    void OnEnable()
    {
        controls.GamePlay.Enable();
    }
    void OnDisable()
    {
        controls.GamePlay.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb.velocity = moveInput * activeMoveSpeed;

        if (Input.GetKey(KeyboardSprint))
        {
            activeMoveSpeed = moveSpeed * sprintMultiplier;
        }
        else
        {
            activeMoveSpeed = moveSpeed;
        }
        
        /*if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("WalkDirection", 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("WalkDirection", 2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("WalkDirection", 3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("WalkDirection", 4);
        }
        if (speeeeed.speed <= 0)
        {
            animator.SetInteger("WalkDirection", 0);
        }
        else
        {

        }*/
    }
}
