using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementwithanim : MonoBehaviour
{

    private Animator animator;
    public float moveSpeed = 2;
    public float turnSpeed = 100;

    public GameObject bulletPrefab;
    void Start()
    {
        animator = GetComponent<Animator>();
        this.transform.position = new Vector3(0, 1, 0);
    }

    void Update()
    {
        animator.SetBool("IsRunning", false);
        Vector3 movement = Vector3.zero;
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow)){
            movement += Vector3.forward;
            animator.SetBool("IsRunning", true);} // Move forward (Z key)
        if (Input.GetKey(KeyCode.DownArrow)){ // Move backward (S key)
           movement += Vector3.back;animator.
           SetBool("IsRunning", true);}
        if (Input.GetKey(KeyCode.A)){ // Move left (Q key)
            movement += Vector3.left;
            animator.SetBool("IsRunning", true);}
        if (Input.GetKey(KeyCode.D)){ // Move right (D key)
            movement += Vector3.right;
            animator.SetBool("IsRunning", true);}
        

        if (Input.GetKeyDown(KeyCode.Space)){
            //spawn de balle
            animator.SetTrigger("CastSpell");
            
            Instantiate(bulletPrefab, this.transform.position+1*Vector3.forward, this.transform.rotation);
            
        }

        movement.Normalize();

        // Apply movement speed and deltaTime
        movement *= moveSpeed * Time.deltaTime;

        // Apply movement to the object
        transform.Translate(movement);
    }

    private void OnTriggerEnter(Collider collision)
    {
        print("Collision"+ collision.gameObject.name);

        if(collision.gameObject.tag== "Enemy"){
            this.transform.position = new Vector3(0, this.transform.position.y, 0);
        }
    }
}
