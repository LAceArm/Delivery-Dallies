using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
[RequireComponent(typeof(AudioSource))]
public class CrateCollission : MonoBehaviour
{
    public GameObject player;
    AudioSource audioSource;
    public AudioClip breakCrate;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
     
     
    }
    void Update()
    {
      float distance=Vector3.Distance(player.transform.position,transform.position);
        if (distance < 2.0 && player.GetComponent<AmmoCounter>().GetShots() <= 12) 
        {
            Destroy(gameObject);
            player.GetComponent<AmmoCounter>().SetShots((player.GetComponent<AmmoCounter>().GetShots())+3);
            audioSource.PlayOneShot(breakCrate, 0.7f);
        }
    }


}
