using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    //same name as UpgradeManager.cs's but not same
    public UnityEngine.UI.Text ItemInfo;
    public Clicker clicker;
    public int cost;
    public int tickValue;
    public int count;

    public Color enough;
    public Color notEnough;

    public string itemName;

    private float _baseCost;

    private void Start()
    {
        _baseCost = cost;
    }

    private void Update()
    {
        ItemInfo.text = itemName + "Cost\n" + cost + "\n /sec \n" + tickValue;

        if (clicker.money >= cost)
        {
            GetComponent<Image>().color = enough;
        }
        else
        {
            GetComponent<Image>().color = notEnough;
        }
    }

    public void PurchasedItem()
    {
        if (clicker.money >= cost)
        {
            clicker.money -= cost;
            count++;
            cost = Mathf.RoundToInt (_baseCost * Mathf.Pow(2, count));
        }
    }


}
