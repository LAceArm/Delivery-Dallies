using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{
    public Transform player;
    public GameObject timer;
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < 15)
        {
            timer.GetComponent<TimerScript>().timeIsFlowing(false);
        }
        else
        {
            timer.GetComponent<TimerScript>().timeIsFlowing(true);
        }
;        
    }
}
