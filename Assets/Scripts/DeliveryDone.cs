using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeliveryDone : MonoBehaviour
{
    public GameObject pointCalculator;
    public GameObject timer;
    public Transform player;
    public Transform deliveryBoy;
    public TextMeshProUGUI helpText;
    public GameObject waypoint;
    public static int deliveriesDone = 0;
    void Start()
    {
        waypoint.SetActive(true);
        helpText.gameObject.SetActive(false);
    }
    void Update()
    {
        float distancefromPlayer=Vector3.Distance(transform.position, player.position);
        float distanceBetweenPlayerAndDelivery = Vector3.Distance(player.position, deliveryBoy.position);
        bool delivered = true;
        Debug.Log(deliveriesDone);
        Debug.Log(delivered);
        if (distancefromPlayer < 15 && distanceBetweenPlayerAndDelivery < 15)
        {
            waypoint.SetActive(false); 
            helpText.gameObject.SetActive(true);
            helpText.text = "Press p and click to make your delivery!";
           
            pointCalculator.GetComponent<PointCalculator>().calculatePoints();
            deliveriesDone++;
            Destroy(gameObject);

        }
        if (distancefromPlayer > 15)
        {
             helpText.gameObject.SetActive(false);
        }
    }
}
