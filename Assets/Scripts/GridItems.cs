
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
    private ItemsSO item;
    [SerializeField] private Image image;

    void setImage()
    {
       image.sprite = item.icon;

    }
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("3 drags are happened");
        UIManager.instance.ShowItemDetails(item);
        setImage();
    }

   

}
