using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnvilManager : MonoBehaviour
{
    public static bool AaddMetal = false;
    public static bool AsubMetal = false;

    void OnMouseDown()
    {
        if (GameManager.gameIsPaused == false)
        {
            if (GameManager.p.metalInHand != null)
            {
                //add metal to anvil
                if (GameManager.p.metalInHand.returnLoc() == "hand")
                {
                    GameManager.p.metalInHand.changeLoc("anvil");
                    AaddMetal = true;
                }
                //takes away metal from anvil
                else if (GameManager.p.metalInHand.returnLoc() == "anvil")
                {
                    GameManager.p.metalInHand.changeLoc("hand");
                    FirePokerManager.deleteSelf = true;
                }
            }
        }
    }
}