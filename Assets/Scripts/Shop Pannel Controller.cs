using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPannelController : MonoBehaviour
{
    [SerializeField] GameObject UpgradesPannel;
    [SerializeField] GameObject FuelsPannel;
    [SerializeField] GameObject WeaponPannel;
    [SerializeField] GameObject RelicsPannel;

    private static ShopPannelController instance;
    public static ShopPannelController ShopPannelInstance { get { return instance; } }


    private GameObject currentActivePanel;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void SetActivePannel(ItemTypes PannelName)
    {
        UpgradesPannel.SetActive(false);
        FuelsPannel.SetActive(false);
        WeaponPannel.SetActive(false);
        RelicsPannel.SetActive(false);

        switch (PannelName)
        {
           
            case ItemTypes.Upgrades:
                {
                    UpgradesPannel.SetActive(true);
                    currentActivePanel = UpgradesPannel;
                    break;
                }
           
            case ItemTypes.Fuels:
                {
                    FuelsPannel.SetActive(true);
                    currentActivePanel = FuelsPannel;
                    break;
                }

            
            case ItemTypes.Weapons:
                {
                    WeaponPannel.SetActive(true);
                    currentActivePanel = WeaponPannel;
                    break;
                }

            
            case ItemTypes.Relics:
                {
                    RelicsPannel.SetActive(true);
                    currentActivePanel = RelicsPannel;
                    break;
                }

        }
    }
}