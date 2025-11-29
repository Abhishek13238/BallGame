using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject canvas;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            GameOver();
        }
    }
    void GameOver()
    {
        canvas.SetActive(true);
    }
}
