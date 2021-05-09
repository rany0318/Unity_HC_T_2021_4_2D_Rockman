﻿using UnityEngine;
using UnityEngine.SceneManagement; // 引用場景管理器 API
public class MenuManager : MonoBehaviour
{
    //使用靜態方法處理 1.開始遊戲 2.離開遊戲
    //如何讓按鈕跟程式溝通
    //需要一個公開的方法
    public void StartGame()
    {
        //延遲呼叫("方法名稱" , 延遲時間)
        Invoke("DelayStartGame", 1.1f);
    }

    private void DelayStartGame()
    {
        //Application.LoadLevel //綠色蚯蚓：過時的 API 建議換新的

        // 場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲畫面");
        //SceneManager.LoadScene(1);
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        //應用程式.離開()
        Application.Quit();
    }

    private void DelayQuitGame()
    {
        //應用程式.離開()
        Application.Quit();
    }
}
