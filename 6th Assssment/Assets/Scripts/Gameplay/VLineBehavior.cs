using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VLineBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            //Replace 'Game Over' with your game over scene's name.
            SceneManager.LoadScene("Game Over");
        }
    }
}
