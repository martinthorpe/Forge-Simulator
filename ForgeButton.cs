using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeButton : MonoBehaviour
{
    void OnMouseDown()
    {
        //addes more coal to forge
        if(ForgeManager.coalList.Count < 200)
        {
            if (GameManager.p.returnCoalBagCount() > 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    Coal x = new Coal();
                    ForgeManager.coalList.Add(x);
                }
                //reduces player's coal bag count
                GameManager.p.reduceCoalBagCount(1);
            }
        }
    }
}
