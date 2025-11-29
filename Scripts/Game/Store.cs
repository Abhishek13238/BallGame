using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    public GameObject canvas;
    
    public void Shop()
    {
        canvas.SetActive(true);
    }
    public void ShopClose()
    {
        canvas.SetActive(false);
    }
}
