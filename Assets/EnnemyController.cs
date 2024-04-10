using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyController : MonoBehaviour
{
    public int hpAmount;
    public NavMeshAgent agent;
    public GameObject player;

    public Animator animator;
    // Start is called before the first frame update
    public Vector3 startPosition;
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        startPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
    
        

        if (Vector3.Distance(player.transform.position, this.transform.position)<=20)
        {
            agent.speed=4;
            agent.SetDestination(player.transform.position);
            animator.SetBool("IsRunning", true);
        }else{
                agent.SetDestination(startPosition);
            
            }

        if(this.transform.position==startPosition){
            animator.SetBool("IsRunning",false);
        }
        }
    

    public void TakeDamage(int value)
    {
        hpAmount -= value;
        if (hpAmount <= 0)
        {
            Destroy(this.gameObject);
        }
    }
  }  


