using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject window;
    private int flag = 0;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flag == 0)
            {
                window.transform.Rotate(0f, -45f, 0f);
                flag = 1;
            }
            else if (flag == 1)
            {
                window.transform.Rotate(0f, 45f, 0f);
                flag = 0;
            }
        }
    }
}
