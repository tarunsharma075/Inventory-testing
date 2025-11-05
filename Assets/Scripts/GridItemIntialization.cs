
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GridItemIntialization : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private  ItemsSO item;
    [SerializeField] private Image image;
    [SerializeField] private GameObject buyButton;
    [SerializeField]private GameObject sellButton;
    [SerializeField] private GameObject shopDetailsPannel;
    [SerializeField] private GameObject inventoryDetailsPannel;

    void setImage()
    {
       image.sprite = item.icon;

    }
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (item.inventoryType == IneventoryType.InventoryPannel)
        {
            if (inventoryDetailsPannel.activeSelf)
            {
                UIManager.instance.ShowInventoryDetails(item);
                setImage();
            }else if(!inventoryDetailsPannel.activeSelf&&shopDetailsPannel.activeSelf)
            {
                shopDetailsPannel.SetActive(false);
                inventoryDetailsPannel.SetActive(true);
                UIManager.instance.ShowInventoryDetails(item);
                setImage();
            }
            else
            {
                inventoryDetailsPannel.SetActive(true);
                UIManager.instance.ShowInventoryDetails(item);
                setImage();
            }

        }
        else if (item.inventoryType == IneventoryType.ShopPannel)
        {
           if(!shopDetailsPannel.activeSelf && inventoryDetailsPannel.activeSelf)
            {
                inventoryDetailsPannel.SetActive(false);
                shopDetailsPannel.SetActive(true);
                UIManager.instance.ShowShopItemDetails(item);
                setImage();
            }
            else if (shopDetailsPannel.activeSelf)
            {
                UIManager.instance.ShowShopItemDetails(item);
                setImage();
            }
            else 
            {
                shopDetailsPannel.SetActive(true);
                UIManager.instance.ShowShopItemDetails(item);
                setImage();
            }
        }

        if (item.inventoryType == IneventoryType.ShopPannel)
        {
            buyButton.SetActive(true);
           
        }
        else if (item.inventoryType == IneventoryType.InventoryPannel)
        {
            sellButton.SetActive(true);
           
        }
    }

    public ItemsSO GetItem()
    {
        return item;
    }


  
}
