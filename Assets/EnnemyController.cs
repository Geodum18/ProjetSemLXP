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
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsRunning", true);
        agent.SetDestination(player.transform.position);
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
