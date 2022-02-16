using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float CLAMP_X = 8.5f;
    private const float CLAMP_Y = 4.5f;

    public static Action onTouched;

    private void OnMouseDrag()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float mousePosClampX = Mathf.Clamp(mousePos.x, -CLAMP_X, CLAMP_X); 
        float mousePosClampY = Mathf.Clamp(mousePos.y, -CLAMP_Y, CLAMP_Y);

        transform.position = new Vector2(mousePosClampX, mousePosClampY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            Destroy(collision.gameObject);
            onTouched?.Invoke();
        }
    }

}
