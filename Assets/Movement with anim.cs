using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movementwithanim : MonoBehaviour
{

    private Animator animator;
    public float moveSpeed;
    public float turnSpeed=100;
    public float maxCooldown1=10;
    private float cooldown1;
    public float maxCooldown2=15;
    private float cooldown2;

    public float maxBoostDuration = 5;
    public Vector3 startPosition;
    public GameObject bulletPrefab;
    void Start()
    {
        animator = GetComponent<Animator>();
        startPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
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
        
        cooldown1-= Time.deltaTime;
        cooldown2-= Time.deltaTime;
        if ((Input.GetKeyDown(KeyCode.Space))&&(cooldown1<=0)){
            //spawn de balle
            animator.SetTrigger("CastSpell");

            

            Instantiate(bulletPrefab, this.transform.position-1*Vector3.forward, this.transform.rotation);
            cooldown1=maxCooldown1;
        }
        if ((Input.GetKeyDown(KeyCode.W))&&(cooldown2<=0)){
           
            cooldown2=maxCooldown2;
            
            }
        if (cooldown2<(maxCooldown2-maxBoostDuration)){
            moveSpeed=4;
        } else {
            moveSpeed=10;
        }


        //MOVEMENT PARAMETERS
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
            //this.transform.position = startPosition;
            SceneManager.LoadScene("Test2");
        }
    }

}