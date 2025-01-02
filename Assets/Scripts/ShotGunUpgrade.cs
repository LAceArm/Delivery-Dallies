using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunUpgrade : MonoBehaviour
{
    public GameObject general;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int points = general.GetComponent<PointCalculator>().getPoints();
        if(points >= 700)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
            if (Input.GetKeyDown("c"))
            {
                Time.timeScale = 1;
                gameObject.SetActive(false);
            }
        }
        
    }
}
