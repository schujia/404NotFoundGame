using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPointAnimation : MonoBehaviour
{

    public GameObject endPointLight;
    public GameObject endText;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider whatHitMe)
    {
        if (whatHitMe.tag == "Player")
        {
            endPointLight.GetComponent<Animator>().Play("endPointLight");
            endText .gameObject.SetActive(true);
        }

    }
}
