using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI SellingPrice;
    [SerializeField] private TextMeshProUGUI BuyingPrice;
    [SerializeField] private TextMeshProUGUI weight;
    [SerializeField] private TextMeshProUGUI rarity;
    [SerializeField] private TextMeshProUGUI quantity;
    [SerializeField] private  Sprite  image;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI type;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        
    }

    public void ShowItemDetails(ItemsSO item)
    {
        if (item == null) return;

        Description.text = item.description;
        SellingPrice.text = "Selling Price " + item.SellingPrice.ToString();
        BuyingPrice.text = "Buying Price " + item.BuyingPrice.ToString();
        weight.text = "Weight " + item.weight.ToString();
        rarity.text = "Rarity : " + item.rarity.ToString();
        quantity.text = "Quantity " + item.quantity.ToString();
        name.text = item.name;
        image = item.icon;
        type.text =  item.type.ToString();
    }
}
