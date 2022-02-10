using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForgeManager : MonoBehaviour
{
    public static List<Coal> coalList = new List<Coal>();
    public static bool FaddMetal = false;
    public static bool FsubMetal = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //add heat
        if (GameManager.p.metalInHand != null)
        {
            if (GameManager.p.metalInHand.returnLoc() == "forge")
            {
                GameManager.p.metalInHand.addTemp(Time.deltaTime * ((coalList.Count / 10) * Bellows.bellowAir));
            }
        }
        //reduce coal timer
        for (int i = 0; i < coalList.Count; i++)
        {
            coalList[i].timerReduce();
        }
        //remove dead coal
        int length = coalList.Count;
        for (int x = 0; x < coalList.Count; x++)
        {
            bool check = coalList[length - (x + 1)].timerCheck();
            if (check == false)
            {
                coalList.RemoveAt(length - (x + 1));
            }
        }
    }

    void OnMouseDown()
    {
        if (GameManager.gameIsPaused == false)
        {
            if (GameManager.p.metalInHand != null)
            {
                //add metal to forge
                if (GameManager.p.metalInHand.returnLoc() == "hand")
                {
                    GameManager.p.metalInHand.changeLoc("forge");
                    FaddMetal = true;
                }
                //takes away metal from forge
                else if (GameManager.p.metalInHand.returnLoc() == "forge")
                {
                    GameManager.p.metalInHand.changeLoc("hand");
                    FirePokerManager.deleteSelf = true;
                }
            }
        }
    }
}