﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCameraBounds : MonoBehaviour
{
    public new CameraMovement camera;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        camera = FindObjectOfType<CameraMovement>();
        spriteRenderer.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            camera.upperLimitHit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            camera.upperLimitHit = false;
        }
    }
}
