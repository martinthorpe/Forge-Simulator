using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirePokerManager : MonoBehaviour
{
    int hitTarget = 10;
    public GameObject Self;
    public static bool deleteSelf = false;
    public Material[] material;
    Renderer rend;

    void Start()
    {
        //sets metal's colour
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        //destroys self
        if (deleteSelf == true)
        {
            Destroy(Self);
            deleteSelf = false;
        }
        if (GameManager.p.metalInHand != null)
        {
            //NEED TO FIX
            if (GameManager.p.metalInHand.returnHitCount() >= hitTarget)
            {
                Destroy(Self);
                GameManager.p.changeMetalInHand();
                AnvilManager.AaddMetal = true;
            }
            //changes metal's colour
            if (GameManager.p.metalInHand.returnTemp() <= 600)
            {
                rend.sharedMaterial = material[0];
            }
            else if (GameManager.p.metalInHand.returnTemp() > 600 && GameManager.p.metalInHand.returnTemp() <= 1400)
            {
                rend.sharedMaterial = material[1];
            }
            else if (GameManager.p.metalInHand.returnTemp() > 1400 && GameManager.p.metalInHand.returnTemp() <= 1600)
            {
                rend.sharedMaterial = material[2];
            }
            else if (GameManager.p.metalInHand.returnTemp() > 1600)
            {
                rend.sharedMaterial = material[3];
                GameManager.p.metalInHand.changeHealth(1 * Time.deltaTime);
            }
        }
    }

    void OnMouseDown()
    {
        if (GameManager.p.metalInHand != null)
        {
            //increases hit count
            if (GameManager.p.metalInHand.returnTemp() > 1400 && GameManager.p.metalInHand.returnLoc() == "anvil")
            {
                GameManager.p.metalInHand.changeHitCount();
            }
            //damages metal health
            else if (GameManager.p.metalInHand.returnTemp() <= 1400 && GameManager.p.metalInHand.returnLoc() == "anvil")
            {
                GameManager.p.metalInHand.changeHealth(1);
            }
        }
    }
}