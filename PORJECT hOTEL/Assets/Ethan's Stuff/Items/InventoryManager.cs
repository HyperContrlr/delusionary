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
    private void Awake()
    {
        //For now, assigns the controls
        controls = new TheControls();
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
                return;
            }
        }
    }
}
