using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missingpicAnimation : MonoBehaviour
{

	public GameObject humanimage;


	// Start is called before the first frame update
	public void OnTriggerEnter(Collider whatHitMe)
	{
		if (whatHitMe.tag == "Player")
		{

            humanimage.gameObject.SetActive(true );
            humanimage.GetComponent<Animator>().Play("missingPicMoving");
		}

	}
}
