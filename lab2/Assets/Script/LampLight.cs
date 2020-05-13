using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour
{
    private Light lampLight;
    private Material materialLight;
    private int flag = 0;

    void Start()
    {
        lampLight = GetComponent<Light>();
        materialLight = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            lampLight.enabled = !lampLight.enabled;
            if (flag == 0)
            {
                Color color = Color.white;
                materialLight.SetColor("_EmissionColor",color*0.4f);
                materialLight.EnableKeyword("_EMISSION");
                flag = 1;
            }
            else if(flag == 1)
            {
                Color color = Color.gray;
                materialLight.SetColor("_EmissionColor",color*0.1f);
                materialLight.EnableKeyword("_EMISSION");
                flag = 0;
            }
            
        }
    }
}
