using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    private int flag = 0;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flag == 0)
            {
                door.transform.Rotate(0f, -80f, 0f);
                flag = 1;
            }
            else if (flag == 1)
            {
                door.transform.Rotate(0f, 80f, 0f);
                flag = 0;
            }
        }
    }
}
