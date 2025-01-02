using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(NavMeshAgent))]

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent navMeshAgent;
    public Vector3 retreatPoint;
    public float aggroRange;
    public AudioClip defeat;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (target != null && distance<=aggroRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
        if (distance < 3) 
        {
            navMeshAgent.SetDestination(retreatPoint);
        }
    }
    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            navMeshAgent.SetDestination(retreatPoint);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Shell"))
        {
            audioSource.PlayOneShot(defeat, 0.7f);
            Destroy(gameObject);
        }
    }
}
