using UnityEngine;

/// <summary>
/// Basic Item SO 
/// </summary>

[CreateAssetMenu(fileName = "Item", menuName = "ItemSo")]
public class ItemSO : ScriptableObject
{
    public ItemType itemType;
    public Sprite itemIcon;

    public string itemDescription;

    public int itemBuyingPrice;
    public int itemSellingPrice;
    public float itemWeight;

    public Rarity itemRarity;

    public int itemQuantity;

}


