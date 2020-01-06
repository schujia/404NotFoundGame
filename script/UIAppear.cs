using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIAppear : MonoBehaviour
{
    bool startImage = true;

    [SerializeField] private Image customImage;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
		{
            if(startImage == true) {

                customImage.enabled = true;

            }
			


		}
        
    }

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			customImage.enabled = false;
            //startImage = false;


		}

	}
}
