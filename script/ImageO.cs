﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageO: MonoBehaviour
{
  

    public GameObject Image;

    public void OpenImage()

    {
      

        if (Image  != null)
        {

          

            Image .SetActive(true);

          

        }

    }
}
