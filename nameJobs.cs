using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameJobs : MonoBehaviour
{
    public Text nameText;
    public int slot;

    // Update is called once per frame
    void Update()
    {
        if (slot == 1)
        {
            nameText.text = JobsMenu.returnJobSlot1().returnName();
        }
        else if (slot == 2)
        {
            nameText.text = JobsMenu.returnJobSlot2().returnName();
        }
        else if (slot == 3)
        {
            nameText.text = JobsMenu.returnJobSlot3().returnName();
        }
    }
}
