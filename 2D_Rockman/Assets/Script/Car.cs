﻿using UnityEngine;

public class Car : MonoBehaviour
{
    //單行註解
    /*  多行註解
     * 
     * 
     */

    // 物件資料 - 欄位 Field:儲存物件資料
    // 欄位語法
    // 修飾詞 類型 名稱 指定 預設值 結尾

    // 四大類型
    // 整數 int : 任何沒有小數點的正負數值
    // 浮點數 float : 任何有小數點的正負數值，有小數點結尾要加f(大小寫皆可)
    // 字串 string : 任何文字，必須使用雙引號 ""
    // 布林值 bool : 正反 true、false

    // 關鍵字 顏色:藍色
    // 自訂顏色 顏色:白色

    // 修飾詞
    // 私人:不顯示 private (預設值)
    // 公開:顯　示 public

    //欄位屬性語法
    //[屬性名稱(屬性內容)]
    //標題 Header
    //提示 Tooltip
    //範圍 Range(最小值，最大值) - 限定數值類型
    [Header("汽車的 cc 數")]
    [Tooltip("調整汽車的 cc 數。")]
    [Range(1000, 5000)]
    public int cc = 2000 ;
    [Header("汽車的重量"),Tooltip("調整汽車的重量。"),Range(0.5f,10)]
    public float weight = 1.5f;
    [Header("汽車的品牌"), Tooltip("輸入汽車的品牌。")]
    public string brand = "BMW";
    [Header("有沒有天窗"), Tooltip("是否加入汽車天窗。")]
    public bool hasWindow = true;

    // Unity 常見類型
    // 顏色 Color
    public Color FirstColor ;
    public Color SecondColor = Color.red;
    public Color red = Color.yellow;

    // 指定顏色的值為 0 - 1
    public Color myColor = new Color(0.3f, 0, 0.6f);          //Color(紅,綠,藍)
    public Color myColor2 = new Color(0, 0.5f, 0.5f, 0.5f);   //Color(紅,綠,藍,透明)

    // 座標二維-四維 Vector2、Vector3、Vector4
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2my = new Vector2(7, 9);

    public Vector3 v3 = new Vector3(1, 2, 3);
    public Vector4 v4 = new Vector4(1, 2, 3, 4);

    //按鍵 KeyCode
    public KeyCode Key1;
    public KeyCode key2 = KeyCode.A;        // 不指定為 None (無)
    public KeyCode key3 = KeyCode.Mouse0;   // 左 0 ，右 1，滾輪 2
    public KeyCode key4 = KeyCode.Joystick1Button0;

    //遊戲物件 與 元件
    //遊戲物件 GameObject
    public GameObject obj1;
    public GameObject obj2;
    //元件 Component - 屬性面板上可摺疊
    //名稱去掉空格
    public Transform tra;                   //可儲存任何包含 Transform 元件的物件
    public SpriteRenderer spr;              //可儲存任何包含 SpriteRenderer 元件的物件




}
