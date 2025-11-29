using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private float inventoryWeight = 100;
    private float currentWeight = 0;
    private float currentMoneyAmount = 0;



    //private float  WeightCheker(float  itemWeight)
    //{
    //    float newWeight= currentWeight + itemWeight;
    //    if (newWeight < inventoryWeight) return -1;
    //    currentWeight = newWeight;
    //    return newWeight;
        

        
    //}
    //public void AddItem(float itemMoney, float itemWeight)
    //{
    //    if(itemMoney<currentMoneyAmount&& (WeightCheker(itemWeight) < inventoryWeight))
    //    {
    //        Debug.Log("Item Added to Inventory");

    //    }else if(itemMoney > currentMoneyAmount)
    //    {
    //        Debug.Log("Not enogh funds popup");
    //    }else if((WeightCheker(itemWeight) > inventoryWeight))
    //    {
    //        Debug.Log("Not enogh space ");
    //    }
    //}
}
