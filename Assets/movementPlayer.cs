using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private Animator animator;
    public float moveSpeed ;

    void Start(){
        //animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        //animator.SetBool("IsRunning", false);
        // Calculate movement based on arrow key input

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += Vector3.right;
            //animator.SetBool("IsRunning", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //animator.SetBool("IsRunning", true);
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //animator.SetBool("IsRunning", true);
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //animator.SetBool("IsRunning", true);
            movement += Vector3.back;
        }

        // Normalize the movement vector to ensure consistent speed regardless of direction
        movement.Normalize();

        // Apply movement speed and deltaTime
        movement *= moveSpeed * Time.deltaTime;

        // Apply movement to the object
        transform.Translate(movement);
    
    }


    

}