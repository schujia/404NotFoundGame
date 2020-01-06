using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointUIAppear : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {


        if (Panel !=null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {

                bool isOpen = animator.GetBool("Open");

                animator.SetBool("Open", !isOpen);

            }

        }



    }
}
