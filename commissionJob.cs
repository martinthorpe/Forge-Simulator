using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commissionJob : MonoBehaviour
{
    public Text commissionText;
    public int slot;

    // Update is called once per frame
    void Update()
    {
        if (slot == 1)
        {
            commissionText.text = JobsMenu.returnJobSlot1().returnCommissionName();
        }
        else if (slot == 2)
        {
            commissionText.text = JobsMenu.returnJobSlot2().returnCommissionName();
        }
        else if (slot == 3)
        {
            commissionText.text = JobsMenu.returnJobSlot3().returnCommissionName();
        }

    }
}
