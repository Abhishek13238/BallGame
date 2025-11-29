using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public Renderer groundRenderer; // assign your 3D ground object
    float scrollSpeed = 0.85f;

    void Update()
    {
        if (groundRenderer != null)
        {
            // Scroll texture in X direction
            Vector2 offset = new Vector2(0, -Time.time * scrollSpeed);
            groundRenderer.material.mainTextureOffset = offset;
        }
    }
}
