using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour {

    public GameObject catBall;
    public int ballCount;
    private bool droped = false;

    private void Update()
    {
        if (!catBall.activeSelf && ballCount > 0)
        {
            ballCount--; 
            catBall.transform.position = this.transform.position;
            catBall.SetActive(true);
            droped = false;
        }

        if (droped == false)
        {
            catBall.GetComponent<Rigidbody2D>().isKinematic = true;
            int direction = (int)Input.GetAxisRaw("Horizontal");

            if (direction == 1 && catBall.transform.position.x < 4)
            {
                Move("rigth");
            }
            else if (direction == -1 && catBall.transform.position.x > -4)
            {
                Move("Left");
            }

            if (Input.GetAxisRaw("Jump") == 1)
            {
                droped = true;
                catBall.GetComponent<Rigidbody2D>().isKinematic = false;
            }

        }
    }

    private void Move(string direction)
    {
        if (direction == "rigth")
        {

            catBall.transform.position += new Vector3(0.2f, 0, 0);

        }
        else
        {

            catBall.transform.position += new Vector3(-0.2f, 0, 0);

        }
    }
}
