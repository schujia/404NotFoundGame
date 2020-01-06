using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageClose : MonoBehaviour
{


    public GameObject Image;

    public void CloseImage()

    {


        if (Image != true  )
        {



            bool isActive = Image.activeSelf;

            Image.SetActive(!isActive);

        }

    }
}
