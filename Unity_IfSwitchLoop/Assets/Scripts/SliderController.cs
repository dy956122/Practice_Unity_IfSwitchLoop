using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    private int Hp = 100;
    public string propDrink;

    public Text hint;
    public Text drinkSomething;
  
    public Slider HpSlider;

    public GameObject Cube;
    //public Slider HpSlider1 { get => HpSlider; set => HpSlider = value; }

    private void Awake()
    {
        CubeArray(10);
    }


    void Update()
    {
        #region 血量 If 判斷式
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
        #endregion 血量 If 判斷式 結束

        drinkSomething.text = propDrink == "紅水" ? "恢復血量" : propDrink == "藍水" ? "恢復魔力" : "你吃錯藥了!!";

        
    }

    #region 設定方塊陣列
    public void CubeArray(int length)
    {
        for (int i = 0; i <= length; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Instantiate(Cube, new Vector3(i, k, 0), Quaternion.Euler(270, 0, 0));
            }
        }
    }
    #endregion 設定方塊陣列 結束

}
