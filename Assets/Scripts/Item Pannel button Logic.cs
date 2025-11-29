using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPannelbuttonLogic : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] private ItemTypes itemName;

    public void OnPointerClick(PointerEventData eventData)
    {
       ShopPannelController.ShopPannelInstance.SetActivePannel(itemName);
    }
}
