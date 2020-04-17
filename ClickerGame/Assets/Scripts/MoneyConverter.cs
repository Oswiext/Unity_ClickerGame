using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyConverter : MonoBehaviour {

    private static MoneyConverter instance;
    public static MoneyConverter Instance
    {
        get
        {
            return instance;
        }
    }

    //later start
    private void Awake()
    {
        CreateInstance();
    }


    void CreateInstance()
    {
        //if its a need of an instance otherwise it will create one
        if (instance == null)
        {
            instance = this;
        }
    }

    public string GetMoneyIntoString(int valueToConvert, bool moneyPerClickBool, bool moneyPerSecBool, string converted)
    {
        if (valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000).ToString("f2") + "M";
        }

        else if (valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000000).ToString("f2") + "K";
        }
        else
        {
            converted = "" + valueToConvert;
        }

        if (moneyPerSecBool == true)
        {
            converted = converted + "PerSec";
        }

        if (moneyPerClickBool == true)
        {
            converted = converted + "PerClick";
        }
        return converted;
    }
}
