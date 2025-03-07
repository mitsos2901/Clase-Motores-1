using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform transform;
    public float speed=0.02f;
    void Update()
    {
     if(Input.GetKey(KeyCode.UpArrow)){
        transform.position= new Vector3(transform.position.x,
        transform.position.y + 0.02f,
        transform.position.z);
     }

     if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.position = new Vector3(transform.position.x,
        transform.position.y -0.02f,
        transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.02f,
            transform.position.y,
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.02f,
            transform.position.y,
            transform.position.z);
        }
        //Keys.Up, Keys.Down, Keys.Left, Keys.right
    }
}
