using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carHandler : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void OnMouseDrag()
    {


        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));




    }
}
