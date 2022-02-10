using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bellows : MonoBehaviour
{
    public static float bellowAir = 0f;

    // Update is called once per frame
    void Update()
    {
        //reduces air by the second
        if (bellowAir > 1f)
        {
            bellowAir -= Time.deltaTime * 0.02f;
        }
    }

    //refills air
    void OnMouseDown()
    {
        bellowAir = 2f;
    }
}
