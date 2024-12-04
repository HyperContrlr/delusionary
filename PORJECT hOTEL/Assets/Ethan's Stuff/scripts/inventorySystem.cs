using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//finish the UI elements later.
//Video link: https://youtu.be/SGz3sbZkfkg?si=0FQnVWTJJzEnCrOE
public class inventorySystem : MonoBehaviour
{
    private Dictionary<itemData, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory {  get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<itemData, InventoryItem>();
    }

    //The error here is that referenceData is an invalid term
    //Add and remove stuff from the inventory list and item dictionary
    /*public void Add(InventoryItem referenceData)
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        }
    }
    public void Remove(InventoryItem referenceData)
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.RemoveFromStack();
            if(value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
        
    }/**/
}
[Serializable]
public class InventoryItem
{
    public itemData data { get; private set; }
    public int stackSize { get; private set; }

    public InventoryItem(itemData source)
    {
        data = source;
        AddToStack();
    }
    public void AddToStack()
    {
        stackSize++;
    }
    public void RemoveFromStack()
    {
        stackSize--;
    }
}
