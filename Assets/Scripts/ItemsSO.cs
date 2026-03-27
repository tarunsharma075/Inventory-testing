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
   
    public  float  quantity;
   
    public  Rarity rarity;

    public string name;

    public ItemTypes type;

}
