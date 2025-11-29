using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GatherButtonmanager : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    [SerializeField] private List<GameObject> items;
   
   
    private ItemsSO itemToUse;

    public void OnPointerClick(PointerEventData eventData)
    {

        OnClick();

    }

    private void OnClick()
    {
        Debug.Log("Gather Button Clicked");

        int Randomitem = Random.Range(0, items.Count);

        //GridItemIntialization currentItem = items[Randomitem].GetComponent<GridItemIntialization>();

        //ItemsSO itemtoUse = currentItem.GetItem();
        

        //if (itemtoUse.rarity != Rarity.Common)
        //{
        //    Debug.Log("You have found a " + itemtoUse.rarity + " item!");
        //}
        //else if(itemtoUse.rarity == Rarity.Common)
        //{
        //    Instantiate(items[Randomitem], gridLayoutGroup.transform);
        //}

        GameObject newItem= Instantiate(items[Randomitem], gridLayoutGroup.transform);
        

        GridItemIntialization newitems = newItem.GetComponent<GridItemIntialization>();
        ItemsSO newItemsPannel = newitems.GetItem();
        newItemsPannel.inventoryType = IneventoryType.InventoryPannel;
        newItemsPannel.inventoryQuantity += 1;
        newItemsPannel.MaxQuanity -= 1;

        UIManager.instance.ChangeAmount(newItemsPannel.SellingPrice);    

    }
}
