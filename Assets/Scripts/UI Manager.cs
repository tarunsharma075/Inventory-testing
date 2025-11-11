using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UIManager : MonoBehaviour

{
    //ShopPannel
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI BuyingPrice;
    [SerializeField] private TextMeshProUGUI weight;
    [SerializeField] private TextMeshProUGUI rarity;
    [SerializeField] private TextMeshProUGUI quantity;
     private Sprite image;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI type;
    public static UIManager instance;
    [SerializeField] TextMeshProUGUI MoneyAmount;
    private   gridtem gridtem;

    //InventoryPannel
    [SerializeField] private TextMeshProUGUI sellingPrice;
    [SerializeField] private TextMeshProUGUI inventoryquantity;

    //SellButton;

    [SerializeField] private TextMeshProUGUI amountText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
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

        Debug.Log("Plus Button Clicked");

        ItemsSO currentItem = gridtem.GetItem();
        float currentItemMaxQuantity = currentItem.MaxQuanity;
        //Debug.Log(currentItemMaxQuantity.ToString());
        float currentBuyingQuantity = 0;
        if(currentBuyingQuantity >= currentItemMaxQuantity)
        {
            //playsound;
        }else
        {

            currentBuyingQuantity += 1;
            amountText.text = currentBuyingQuantity.ToString();

        }


    }


    public void  ShowInventoryDetails(ItemsSO item)
    {
        sellingPrice.text = "Selling Price: " +" "+ item.SellingPrice;
        inventoryquantity.text = "Quantity: " + " " + item.inventoryQuantity;
    }


    public void  setGridItem(  gridtem currentItem)
    {
        gridtem = currentItem;
    }


    public  void OnClickSell()
    {
        if(amountText.text == "")
        {
            //playsound;
        }
        Debug.Log("Sell Button Clicked");
        ItemsSO currentItem = gridtem.GetItem();
        float currentItemPrice = currentItem.SellingPrice;
        float  numberofitems = float.Parse(amountText.text);
        MoneyAmount.text =  ( (float.Parse(MoneyAmount.text)+currentItemPrice * numberofitems).ToString());
        currentItem.inventoryQuantity -= 1;
        inventoryquantity.text = "Quantity: " + " " + currentItem.inventoryQuantity;

    }
}
