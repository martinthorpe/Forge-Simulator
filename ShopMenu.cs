using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject shopMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (openShop.openShopM == true && GameManager.gameIsPaused == false)
        {
            if (GameManager.gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        openShop.openShopM = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        shopMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameManager.gameIsPaused = false;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        shopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameManager.gameIsPaused = true;
    }

    public void buyMetal()
    {
        if(GameManager.p.returnGoldCoins() >= 10)
        {
            GameManager.p.addMetalBars(1);
            GameManager.p.reduceGoldCoins(10);
        }
    }

    public void buyCoal()
    {
        if(GameManager.p.returnGoldCoins() >= 1)
        {
            GameManager.p.addeCoalBagCount(1);
            GameManager.p.reduceGoldCoins(1);
        }
    }
}