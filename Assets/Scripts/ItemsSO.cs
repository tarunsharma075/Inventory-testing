using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "item" , menuName = "Inventory/Item")]
public class ItemsSO : ScriptableObject
{

    
    public Sprite  icon;
    
    public float BuyingPrice;
    
    public  float   SellingPrice;
    
    public  float  weight;
   
    public  string description;
   
    public  float  MaxQuanity;
   
    public  Rarity rarity;

    public string name;

    public ItemTypes type;

    public IneventoryType inventoryType;

    public float inventoryQuantity;

}
