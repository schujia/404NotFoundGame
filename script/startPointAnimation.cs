using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPointAnimation : MonoBehaviour
{
    public GameObject exit;
    public GameObject startPoint;

    bool StartPoint = true;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {

                exit.GetComponent<Animator>().Play("jiantou");


       
     
        }

    }

    private void OnTriggerExit(Collider startPoint)
    {
        if (startPoint.CompareTag("Player"))
        {

            exit.gameObject.SetActive(false);

        }

      
    }

}
