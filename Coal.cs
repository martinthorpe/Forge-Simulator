using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal
{
    float timer;

    public Coal()
    {
        timer = 600f;
    }

    //reduces coal timer
    public void timerReduce()
    {
        timer -= Time.deltaTime * (ForgeManager.coalList.Count / 50);
    }

    //checks if coal's timer is over
    public bool timerCheck()
    {
        if (timer <= 0)
        {
            return false;
        }
        return true;
    }
}