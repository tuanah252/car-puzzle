using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadHandler : MonoBehaviour
{
    private int rotation = 0;
    public LayerMask roadLayerMask; // thêm LayerMask để chỉ định lớp road

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition, roadLayerMask); // sử dụng OverlapPoint() với LayerMask

            if (collider != null)
            {
                rotation += 90;
                collider.gameObject.transform.Rotate(0, 0, rotation);
            }
        }
    }
}
