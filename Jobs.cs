using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jobs
{
    int coinsGained;
    int commissionCode;
    string commissionName;
    string name;

    public Jobs()
    {
        coinsGained = Random.Range(2, 5) * 10;
        commissionCode = 16;
        commissionName = "Fire Poker";
        int choice = Random.Range(1, 6);
        if (choice == 1)
        {
            name = "Jonathan Schlatt";
        }
        else if (choice == 2)
        {
            name = "William Gold";
        }
        else if (choice == 3)
        {
            name = "Tom Simons";
        }
        else if (choice == 4)
        {
            name = "Toby Smith";
        }
        else if (choice == 5)
        {
            name = "George Nott";
        }
    }

    public int returnCoinsGained()
    {
        return coinsGained;
    }

    public int returnCommissionCode()
    {
        return commissionCode;
    }

    public string returnCommissionName()
    {
        return commissionName;
    }

    public string returnName()
    {
        return name;
    }
}