using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour

{
    //ShopPannel
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI BuyingPrice;
    [SerializeField] private TextMeshProUGUI weight;
    [SerializeField] private TextMeshProUGUI rarity;
    [SerializeField] private TextMeshProUGUI quantity;
    [SerializeField] private Sprite image;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI type;
    public static UIManager instance;
    [SerializeField] TextMeshProUGUI MoneyAmount;

    //InventoryPannel
    [SerializeField] private TextMeshProUGUI sellingPrice;
    [SerializeField] private TextMeshProUGUI inventoryquantity;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    

    public void ShowShopItemDetails(ItemsSO item)
    {
        if (item == null) return;

        Description.text = item.description;
        BuyingPrice.text = "Buying Price " + item.BuyingPrice.ToString();
        weight.text = "Weight " + item.weight.ToString();
        rarity.text = "Rarity : " + item.rarity.ToString();
        quantity.text = "Quantity " + item.MaxQuanity.ToString();
        name.text = item.name;
        image = item.icon;
        type.text =  item.type.ToString();
    }


   public void ChangeAmount(float  SellingPrice)

    {
        float  Amount = float.Parse(MoneyAmount.text) + SellingPrice;
        MoneyAmount.text = Amount.ToString();
    }


    public float GetSellingprice() {

       return float.Parse(sellingPrice.text);
    }

    public float GetBuyingprice()
    {

        return float.Parse(BuyingPrice.text);
    }

    public void OnCrossClick(GameObject itemtoclose)
    {
        
        itemtoclose.SetActive(false);
    }

    public void OnPlusClick()
    {
        


    }


    public void  ShowInventoryDetails(ItemsSO item)
    {
        sellingPrice.text = "Selling Price: " +" "+ item.SellingPrice;
        inventoryquantity.text = "Quantity: " + " " + item.inventoryQuantity;
    }
}
