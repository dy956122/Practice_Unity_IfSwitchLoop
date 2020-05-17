using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour // 總區塊
{
    #region 設定基礎數值與欄位
    /// <summary>
    /// 血量設定
    /// </summary
    private int _Hp;
    public int Hp { get => _Hp; set => _Hp = value; }

    public Slider HpSlider; // 血條拉霸

    public string propDrink; //文字輸入欄位

    public Text hint; // 文字血條輸出

    public Text drinkthing; // 文字藥水輸出

    public GameObject Cube; //陣列用物件
    #endregion 設定基礎數值與欄位 結束


    private void Awake()
    {
        CubeArray(10);
    }

    private void Update()
    {
        HpValue();

        drinkthing.text = propDrink == "紅水" ? "恢復血量" : propDrink == "藍水" ? "恢復魔力" : "";
    }



    public void InputString(string something) // 文字輸入
    {
        propDrink = something;
    } // 文字輸入 結束
 

    public void HpValue() // 血量 If 判斷式
    {
        Hp = (int)HpSlider.value ;  //強制型別轉換
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

    } // 血量 If 判斷式 結束


    public void CubeArray(int length) //設定方塊陣列
    {
        for (int i = 0; i <= length; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Instantiate(Cube, new Vector3(i, k, 0), Quaternion.Euler(270, 0, 0));
            }
        }
    } // 設定方塊陣列 結束
} // 總區塊 結束
