using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPosition_RayCasting_Delivery : MonoBehaviour
{
    public GameObject cannister;
    private AudioSource audioSource;
    public AudioClip can;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 clickPosition = -Vector3.one;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit delivered;
            if (Physics.Raycast(ray, out delivered))
            {
               clickPosition = delivered.point;
               Instantiate(cannister);
                audioSource.PlayOneShot(can,0.7f);
               cannister.transform.position = clickPosition;
            }
        }

    }
}
