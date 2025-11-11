using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPannelbuttonLogic : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] private ItemTypes itemName;
    [SerializeField] private ShopPannelController ShopPannelInstance;

    public void OnPointerClick(PointerEventData eventData)
    {
       ShopPannelInstance.SetActivePannel(itemName);
    }
}
