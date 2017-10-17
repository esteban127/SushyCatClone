using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trigger : MonoBehaviour {

    public GameObject CatBall;    
    public int score;
    public bool isPickUp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            MyGameManager.instance.AddScore(score);
            if (isPickUp)
                Destroy (gameObject);
            else
                CatBall.SetActive(false);
        }
    }
}
