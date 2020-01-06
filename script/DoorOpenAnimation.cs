using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAnimation : MonoBehaviour
{
    public GameObject Door;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {
            Door.GetComponent<Animator>().Play("DoorOpen");
        }

    }
}
