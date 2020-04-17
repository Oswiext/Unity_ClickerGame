using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    //Importing reference clicker.cs file
    public Clicker clicker;

    public UnityEngine.UI.Text itemInfo;
    public string itemName;

    public float cost;
    public int count = 0;
    public int clickPower;

    public Color enough;
    public Color notEnough;

    // "_" so we know its a float
    // private we don't need it in unity inspector
    private float _baseCost;

    //when starting the game 
    private void Start()
    {
        _baseCost = cost;
    }


    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;

        if(clicker.money >= cost)
        {
            GetComponent<Image>().color = enough;
        }
        else
        {
            GetComponent<Image>().color = notEnough;
        }
    }

    public void PurchasedUpgrade()
    {
        if (clicker.money >= cost)
        {
            clicker.money -= cost;
            count += 1;
            clicker.moneyPerClick += clickPower;
            /* Mathf (Math function) core Module of unity
             * "Round" for float with (cost * 1.50f) 50% increase and "f" after value because its a float
            Round/RoundToInt Returns f rounded to the nearest integer. */
            //This increases the cost for PurchasedUpgrade by 2
            //cost = Mathf.RoundToInt(cost * 2);
            //Pow Returns f raised to power p.
            //_baseCost = Mathf.Pow(cost, _baseCost = cost);

            //cost = Mathf.RoundToInt(_baseCost * Mathf.Pow(2, count));
            cost = Mathf.Round(_baseCost * Mathf.Pow(1.5f, count));
        }
        /*
        else (clicker.money < cost)
            {
                
            }
            */
        }
    }
