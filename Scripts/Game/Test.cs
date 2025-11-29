using UnityEngine;

public class Test : MonoBehaviour
{
    public AudioClip testClip;
    void Start()
    {
        AudioSource.PlayClipAtPoint(testClip, Vector3.zero);
    }
}