using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior: MonoBehaviour
{
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManagerBehavior>().EndGame();
        }

        if (collision.collider.tag == "Victory Line")
        {
            Application.Quit();
        }
    }
}
