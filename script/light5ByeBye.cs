
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light5ByeBye : MonoBehaviour
{
    public GameObject exit;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {
            exit.GetComponent<Animator>().Play("lightByeBye5");
        }

    }
}
