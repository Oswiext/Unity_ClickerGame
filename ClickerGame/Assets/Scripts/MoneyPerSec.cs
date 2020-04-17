using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPerSec : MonoBehaviour {

    public UnityEngine.UI.Text moneySec;
    public Clicker clicker;
    public ItemManager[] items;

    private void Start()
    {
        StartCoroutine(AutoTick());
    }

    private void Update()
    {
        moneySec.text = "sec \n" + GetMoneyPerSec();
    }

    private int GetMoneyPerSec()
    {
        //tick value only accessible inside function
        int tick = 0;
        //foreach because we have an array
        // "item in" is always
        foreach(ItemManager item in items)
        {
            //count and tickvalue from ItemManager.cs
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoMoneyPerSec()
    {
        //clicker.cs to money int
        //parantheses at end because it is a function
        clicker.money += GetMoneyPerSec() /2;
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoMoneyPerSec();
            //"yield" for iterator that operates in a sequence and removes the need of a class for Enumerator
            yield return new WaitForSeconds(0.5f);
        }
    }

}
