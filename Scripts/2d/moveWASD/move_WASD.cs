using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_WASD : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;

    public void Update()
    {
        //Gets the Axis of Input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Moves object based on Axis Input
        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }
}