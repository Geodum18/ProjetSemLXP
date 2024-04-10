using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class ResetEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter(Collider collision)
    {
        print("Collision"+ collision.gameObject.name);

        if(collision.gameObject.tag== "Player"){
            enemy.transform.position = startPosition;
        }
    }*/
}
