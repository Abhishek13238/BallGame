using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float xInput;
    public float moveSpeed;
    public AudioClip coinSound;
    private AudioSource audioSource;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        if (transform.position.y < -29f)
        {
            float xVelocity = xInput * moveSpeed;
            rb.linearVelocity = new Vector3(xVelocity, rb.linearVelocity.y, 0);
            Move();
        }

    }
    void Move()
    {
        rb.AddForce(Vector3.forward * 100000);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(coinSound);
            Destroy(collision.gameObject);
        }
    }
}

