using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Item Data")]
public class itemData : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
    public string description;
}



//I was working on an inventory system,
//but I decided I hated it,
//so I deleted it, and am starting it over