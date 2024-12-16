using System;
using System.Collections.Generic;
using System.Drawing;
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
    public GameObject item;
    public bool canPickUp = false;

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
        //When the button is held, it sprints
        Sprint.action.performed += Sprint_started;
        Sprint.action.performed -= Sprint_cancelled;
        //When the button is released, it stops
        Sprint.action.canceled += Sprint_cancelled;
        Sprint.action.canceled -= Sprint_started;

        //Other one button press stuff
        Interact.action.started += Interact_started;
    }
    private void Interact_started(InputAction.CallbackContext obj)
    {
        if (canPickUp)
        {
            item.GetComponent<itemData>().ItemPickUp();
            Debug.Log("Interact Pressed");
        }
    }
    private void Sprint_started(InputAction.CallbackContext obj)
    {
        activeMoveSpeed = moveSpeed * sprintMultiplier;
        Debug.Log("Sprint Pressed");
    }
    private void Sprint_cancelled(InputAction.CallbackContext obj)
    {
        activeMoveSpeed = moveSpeed;
        Debug.Log("Sprint Released");
    }

    void OnDisable()
    {
        Sprint.action.started -= Sprint_started;
        Sprint.action.canceled -= Sprint_cancelled;
        Interact.action.started -= Interact_started;
    }
    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = moveSpeed;
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            Debug.Log(other.gameObject.name);
            canPickUp = true;
            item = other.gameObject;
        }
    }
    public void OnCollisionExit(Collision other)
    {
        canPickUp = false;
    }
    // Update is called once per frame
    void Update()
    {

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb.velocity = moveInput * activeMoveSpeed;
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
