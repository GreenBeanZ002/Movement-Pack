using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToMove : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 target;
    public Animator anim;
    private bool Walking;
    public bool canWalk = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Get mouse position
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        }
        //Figue out where to walk
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        Vector3 direction = (target - transform.position).normalized;
    }
}
