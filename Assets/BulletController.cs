using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10;
    public float timer = 5;
    void Start()
    {
        timer = 5;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
        if(timer<=0){
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision"+ collision.gameObject.name);

        if(collision.gameObject.tag== "Wall"){
            Destroy(gameObject);
        }
    }
}