using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {

    }

    void Update()
    {
        
        this.transform.position += this.transform.forward * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision"+ collision.gameObject.name);

        if(collision.gameObject.tag== "Wall"){
            Destroy(gameObject);
        }
    }
}