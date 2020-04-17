using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour {

    /*public so we can get them from Unity platform
    UnityEngine to UI to Text object named moneyDisplay */
    public UnityEngine.UI.Text moneyDisplay;
    public UnityEngine.UI.Text moneyClick;

    public float money = 0;
    public int moneyPerClick = 1;

    //function to update (no information to pass in parantes right now)
    private void Update()
    {
        /*to display money each updated frame
        moneyDisplay object takes in a text and int money*/
        moneyDisplay.text = "money \n" + money;
        moneyClick.text = "per click \n" + moneyPerClick;

    }

    public void Clicked()
    {
        //money += moneyPerClick;
        money = money + moneyPerClick;
        transform.Rotate(0, 0, 22);
    }



}
