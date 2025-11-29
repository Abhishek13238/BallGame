using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoin : MonoBehaviour
{
    public Text totalCoinsText;

    void Start()
    {
        int totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        if (totalCoinsText != null)
        {
            totalCoinsText.text = "" + totalCoins;
        }
    }
}
