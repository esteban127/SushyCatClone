using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour {

    public GameObject CatBall;
    private bool isTrow = false;
   

    public void spawnCat()
    {
        if (!isTrow)
        {
            if (Input.GetAxis("Fire1") == 1)
            {

                isTrow = true;
            }


        }
    }
}
