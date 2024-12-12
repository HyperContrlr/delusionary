using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemData : MonoBehaviour
{
    [SerializeField]
    private string itemName;
    [SerializeField]
    private string description;
    [SerializeField]
    private string ID;
    [SerializeField]
    public Sprite itemSprite;

    private InventoryManager inventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    //Will be called whenever the item would get picked up
    void ItemPickUp()
    {
        inventoryManager.AddItem(itemName, description, ID, itemSprite);
        Destroy(this.gameObject);
    }
}