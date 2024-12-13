using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class itemSlot : MonoBehaviour
{
    //item data stuff
    public string itemName;
    public string description;
    public Sprite itemSprite;
    public bool isTaken;

    //item slot stuff
    [SerializeField]
    private Image itemImage;
    
    public void AddItem(string itemName , string description, string iD, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.description = description;
        this.itemSprite = itemSprite;
        isTaken = true;
        itemImage.sprite = itemSprite;
    }
}
