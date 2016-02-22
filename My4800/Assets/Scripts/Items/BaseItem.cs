using UnityEngine;
using System.Collections;

public class BaseItem
{

    private string itemName;
    private string itemDescription;
    private int itemID;

    public enum itemTypes
    {
        EQUIPMENT,
        WEAPON,
        CHEST,
        SCROLL,
        POTION
    }

    private itemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public itemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}
