using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    private int Hp;
    public int Hp1 { get => Hp; set => Hp = value; }


    public Text hint;
    public Text drinkSomething;
    public string propDrink;

    void Update()
    {
        if (Hp <= 30)
        {
            hint.text = "危險!!";
        }
        else if (Hp <= 70)
        {
            hint.text = " 警告!";
        }
        else
        {
            hint.text = "安全~";
        }

        switch (propDrink)
        {
            case "紅水":
                drinkSomething.text = "回復血量" ;
                break;

            default:
                break;
        }


    }
}
