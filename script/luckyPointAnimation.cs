using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luckyPointAnimation : MonoBehaviour
{
    public GameObject jiantou;
    public GameObject arrivePoint;

    bool StartPoint = true;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {
            
            jiantou.gameObject.SetActive(true);
            jiantou.GetComponent<Animator>().Play("jiantou3");




        }

    }

    private void OnTriggerExit(Collider arrivePoint)
    {
        if (arrivePoint.CompareTag("Player"))
        {

            jiantou .gameObject.SetActive(false);

        }


    }
}
