using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManageer : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public int totalCoins = 0;
    public AudioClip coinSounds;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        score = 0;
        UpdateUI();
    }

    void Update()
    {
        UpdateUI();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            audioSource.PlayOneShot(coinSounds);
            score++;
            UpdateUI();

        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + score;
        }
    }

    public void SavedCoins()
    {
        totalCoins += score;
        PlayerPrefs.SetInt("TotalCoins", totalCoins);
        PlayerPrefs.Save();
        score = 0;
        UpdateUI();
    }

    void OnApplicationQuit()
    {
        SavedCoins();
    }

}
