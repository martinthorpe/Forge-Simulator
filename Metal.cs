using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal
{
    int metalCode;
    int thickness;
    int hitCount;
    string loc;
    float temp;
    float health;

    public Metal(int c, float t, string l, float h)
    {
        metalCode = c;
        thickness = 2;
        hitCount = 0;
        loc = l;
        temp = t;
        health = h;
    }

    public int returnCode()
    {
        return metalCode;
    }

    public int returnThickness()
    {
        return thickness;
    }

    public int returnHitCount()
    {
        return hitCount;
    }

    public void changeHitCount()
    {
        hitCount++;
    }

    public string returnLoc()
    {
        return loc;
    }

    public void changeLoc(string l)
    {
        loc = l;
    }

    public float returnTemp()
    {
        return temp;
    }

    public void addTemp(float h)
    {
        temp += h;
    }

    public void reduceTemp(float h)
    {
        temp -= h;
    }

    public float returnHealth()
    {
        return health;
    }

    public void changeHealth(float d)
    {
        health -= d;
        if (health <= 0)
        {
            FirePokerManager.deleteSelf = true;
            destroyed();
        }
    }

    void destroyed()
    {
        GameManager.p.metalInHand = null;
    }
}