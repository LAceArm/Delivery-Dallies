using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
    public TextMeshProUGUI endText;
    public GameObject points;
    public GameObject w1;
    public GameObject w2; 
    public GameObject w3;
    public GameObject w4;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int pointCount = points.GetComponent<PointCalculator>().getPoints();
        bool done=w1.activeInHierarchy && w2.activeInHierarchy && w3.activeInHierarchy && w4.activeInHierarchy;
        if (done)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
            endText.text = "You made " + pointCount.ToString() + " points";
        }
        
    }
}
