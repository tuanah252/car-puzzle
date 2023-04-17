using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cell;
    public int nunber;
    void Start()
    {
        for (int i = 0; i < nunber; i++)
        {
            Instantiate(cell, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
