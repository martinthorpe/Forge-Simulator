using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public Metal metalInHand = null;
    int goldCoins;
    int metalBars;
    int coalBagCount;
    Jobs currentJob;


    public Player()
    {
        metalInHand = null;
        goldCoins = 20;
        metalBars = 1;
        coalBagCount = 20;
        currentJob = null;
    }

    public int returnGoldCoins()
    {
        return goldCoins;
    }

    public void addGoldCoins(int c)
    {
        goldCoins += c;
    }

    public void reduceGoldCoins(int c)
    {
        goldCoins -= c;
    }

    public int returnMetalBars()
    {
        return metalBars;
    }

    public void addMetalBars(int c)
    {
        metalBars += c;
    }

    public void reduceMetalBars(int c)
    {
        metalBars -= c;
    }

    public int returnCoalBagCount()
    {
        return coalBagCount;
    }

    public void addeCoalBagCount(int c)
    {
        coalBagCount += c;
    }

    public void reduceCoalBagCount(int c)
    {
        coalBagCount -= c;
    }

    public void changeJob(Jobs j)
    {
        currentJob = j;
    }

    public Jobs returnCurrentJob()
    {
        return currentJob;
    }

    public void addMetal(int c, float t, string l, float h)
    {
        metalInHand = new Metal(c, t, l, h);
    }

    public void changeMetalInHand()
    {
        //changes metal in hand
        int cc = metalInHand.returnCode();
        if (cc > 10 && cc < 16)
        {
            metalInHand = new Metal(cc + 1, metalInHand.returnTemp(), "anvil", metalInHand.returnHealth());
        }
        else
        {
            metalInHand = new Metal(cc, metalInHand.returnTemp(), "anvil", metalInHand.returnHealth());
        }
    }

    public void removeMetalInHands()
    {
        metalInHand = null;
    }
}