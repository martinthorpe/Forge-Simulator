using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Player p;
    public static bool gameIsPaused = false;

    void Start()
    {
        //makes player object
        p = new Player();
    }

    void Update()
    {
        //reduces metal temp
        if (p.metalInHand != null)
        {
            if (p.metalInHand.returnLoc() != "forge" && p.metalInHand.returnTemp() > 1f)
            {
                p.metalInHand.reduceTemp(Time.deltaTime * 10);
            }
        }
    }
}