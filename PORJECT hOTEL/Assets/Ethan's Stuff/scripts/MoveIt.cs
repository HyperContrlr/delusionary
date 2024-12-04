using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;

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
    public InputActionReference Sprint, Interact, Pause, InventoryL, InventoryR;

    private void Awake()
    {
        //For now, assigns the controls
        controls = new TheControls();
    }
    void OnEnable()
    {
        Sprint.action.performed += Sprint_started;
        Sprint.action.canceled -= Sprint_started;
        Interact.action.started += Interact_started;
    }
    private void Interact_started(InputAction.CallbackContext obj)
    {
        Debug.Log("Interact Pressed");
    }
    private void Sprint_started(InputAction.CallbackContext obj)
    {
        if (Sprint.action.IsInProgress())
        {
            activeMoveSpeed = moveSpeed * sprintMultiplier;
        }
        else if (!Sprint.action.IsInProgress()) 
        {
            activeMoveSpeed = moveSpeed;
        }
        Debug.Log("Sprint Pressed");
        /*activeMoveSpeed = moveSpeed * sprintMultiplier;
        if (Sprint.action.canceled -= )
        {
            Debug.Log("sprint Released");
        }
        /**/
    }

    void OnDisable()
    {
        Sprint.action.started -= Sprint_started;
        Interact.action.started -= Interact_started;
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

        /*if (controls.game.Sprint.IsInProgress())
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
