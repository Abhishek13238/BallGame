using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRoatation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 3.5f, 0);
    }
}
