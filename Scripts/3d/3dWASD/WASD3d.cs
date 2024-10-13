using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD3d : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    [SerializeField] int moveSpeed = 10;

    private int originalSpeed;
    const float yValue = 0f;

    void Start()
    {
        originalSpeed = moveSpeed;
    }

    void FixedUpdate()
    {
        MovePlayer();
    }


    //Moves the player according to moveSpeed
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            //Look Down
        }
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            //Look Up
        }
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") < 0)
        {
            //Look Right
        }
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") > 0)
        {
            //Look Left
        }
        //Might need to do 8 directions rather than 4
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            originalSpeed = moveSpeed;
            moveSpeed = moveSpeed * 2;
        }
        else
        {
            moveSpeed = originalSpeed;
        }
    }
}
