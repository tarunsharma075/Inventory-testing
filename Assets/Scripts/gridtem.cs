
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class gridtem : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private  ItemsSO item;
    [SerializeField] private Image image;
    [SerializeField] private GameObject buyButton;
    [SerializeField]private GameObject sellButton;
    [SerializeField] private GameObject shopDetailsPannel;
    [SerializeField] private GameObject inventoryDetailsPannel;



    public void Start()
    {
        UIManager.instance.setGridItem(this);
    }
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
            }
            else if (shopDetailsPannel.activeSelf)
            {
                shopDetailsPannel.SetActive(false);
                inventoryDetailsPannel.SetActive(true);
                UIManager.instance.ShowInventoryDetails(item);
            }
            else
            {
                inventoryDetailsPannel.SetActive(true);
                UIManager.instance.ShowInventoryDetails(item);
            }

            sellButton.SetActive(true);
            buyButton.SetActive(false);

            setImage();
        }
        else if (item.inventoryType == IneventoryType.ShopPannel)
        {
            if (inventoryDetailsPannel.activeSelf)
            {
                inventoryDetailsPannel.SetActive(false);
                shopDetailsPannel.SetActive(true);
                UIManager.instance.ShowShopItemDetails(item);
                UIManager.instance.setGridItem(this);
            }
            else if (shopDetailsPannel.activeSelf)
            {
                UIManager.instance.ShowShopItemDetails(item);
                UIManager.instance.setGridItem(this);
            }
            else
            {
                shopDetailsPannel.SetActive(true);
                UIManager.instance.ShowShopItemDetails(item);
                UIManager.instance.setGridItem(this);
            }

           
            buyButton.SetActive(true);
            sellButton.SetActive(false);

            setImage();
        }

    }

    public ItemsSO GetItem()
    {
        return item;
    }



  
}
