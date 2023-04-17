using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private int rotation = 0;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Kiểm tra xem người dùng đã nhấp chuột trái hay chưa
        {
            // Tạo một Raycast từ điểm nhấp chuột trên màn hình
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null) // Kiểm tra xem Raycast đã va chạm với một đối tượng hay không
            {

                rotation += 90;
                hit.collider.gameObject.transform.Rotate(0, 0, rotation);
            }
        }
    }
}
