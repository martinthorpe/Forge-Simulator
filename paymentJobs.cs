using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paymentJobs : MonoBehaviour
{
    public Text paymentText;
    public int slot;

    // Update is called once per frame
    void Update()
    {
        if (slot == 1)
        {
            paymentText.text = JobsMenu.returnJobSlot1().returnCoinsGained().ToString();
        }
        else if (slot == 2)
        {
            paymentText.text = JobsMenu.returnJobSlot2().returnCoinsGained().ToString();
        }
        else if (slot == 3)
        {
            paymentText.text = JobsMenu.returnJobSlot3().returnCoinsGained().ToString();
        }
    }
}
