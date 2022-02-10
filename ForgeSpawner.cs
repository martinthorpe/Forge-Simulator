using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeSpawner : MonoBehaviour
{
    public GameObject Metal11;
    public GameObject Metal12;
    public GameObject Metal13;
    public GameObject Metal14;
    public GameObject Metal15;
    public GameObject Metal16;

    // Update is called once per frame
    void Update()
    {
        //spawns in metal
        if (ForgeManager.FaddMetal == true)
        {
            if (GameManager.p.metalInHand.returnCode() == 11)
            {
                Instantiate(Metal11, transform.position, transform.rotation);
            }
            else if (GameManager.p.metalInHand.returnCode() == 12)
            {
                Instantiate(Metal12, transform.position, transform.rotation);
            }
            else if (GameManager.p.metalInHand.returnCode() == 13)
            {
                Instantiate(Metal13, transform.position, transform.rotation);
            }
            else if (GameManager.p.metalInHand.returnCode() == 14)
            {
                Instantiate(Metal14, transform.position, transform.rotation);
            }
            else if (GameManager.p.metalInHand.returnCode() == 15)
            {
                Instantiate(Metal15, transform.position, transform.rotation);
            }
            else if (GameManager.p.metalInHand.returnCode() == 16)
            {
                Instantiate(Metal16, transform.position, transform.rotation);
            }
            ForgeManager.FaddMetal = false;
        }
    }
}