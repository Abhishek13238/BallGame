using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Death : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        if (transform.position.y < -50)
        {
            FallDeath();
        }
    }

    void FallDeath()
    {
        canvas.SetActive(true);
    }
}
