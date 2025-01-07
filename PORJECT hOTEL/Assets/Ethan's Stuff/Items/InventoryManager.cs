using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;

public class InventoryManager : MonoBehaviour
{
    TheControls controls;
    public GameObject Inventorymenu;
    private bool menuActive;
    public itemSlot[] itemSlot;

    public InputActionReference inventory;

    public bool puzzle1;
    public bool puzzle2;
    public bool puzzle3;
    public bool doll1;
    public bool doll2;
    public bool doll3;
    public bool keycard1;
    public bool keycard2;

    private void Awake()
    {
        //For now, assigns the controls
        controls = new TheControls();
        puzzle1 = false;
        puzzle2 = false;
        puzzle3 = false;
        doll1 = false; 
        doll2 = false;
        doll3 = false;
        keycard1 = false; 
         keycard2 = false;
    }
    private void OnEnable()
    {
        inventory.action.started += OpenInv;
    }
    private void OpenInv(InputAction.CallbackContext obj)
    {
        if (!menuActive)
        {
            Time.timeScale = 0;
            Inventorymenu.SetActive(true);
            menuActive = true;
        }
        else if (menuActive)
        {
            Time.timeScale = 1;
            Inventorymenu.SetActive(false);
            menuActive = false;
        }
    }
    
    private void OnDisable()
    {
        inventory.action.started -= OpenInv;
    }

    public void AddItem(string itemName, string description, string ID, Sprite itemSprite)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if(itemSlot[i].isTaken == false)
            {
                itemSlot[i].AddItem(itemName, description, ID, itemSprite);
                if (ID == "1")
                {
                    puzzle1 = true;
                }
                else if (ID == "2")
                {
                    puzzle2 = true;
                }
                else if (ID == "3")
                {
                    puzzle3 = true;
                }
                else if (ID == "4")
                {
                    doll1 = true;
                }
                else if (ID == "5")
                {
                    doll2 = true;
                }
                else if (ID == "6")
                {
                    doll3 = true;
                }
                else if (ID == "7")
                {
                    keycard1 = true;
                }
                else if (ID == "8")
                {
                    keycard2 = true;
                }
                return;
            }
        }
    }
}