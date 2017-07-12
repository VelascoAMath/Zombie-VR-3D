using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector3 pos =
        GetComponent<Transform>().position;
        pos.y = 2.5f;
        GetComponent<Transform>().position = pos;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().Translate(Vector3.forward / 10, GetComponent<Transform>());
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().Translate(Vector3.left / 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().Translate(Vector3.back / 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().Translate(Vector3.right / 10);
        }
    }
}
