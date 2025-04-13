using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control_Light : MonoBehaviour
{
    public GameObject lamp; 
    void Start()
    {
        if (lamp != null)
        {
            
            lamp.SetActive(PersistentStateManager.Instance.isLightOn);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lamp != null)
            {
                bool isOn = !lamp.activeSelf;
                lamp.SetActive(isOn); 
                PersistentStateManager.Instance.isLightOn = isOn; 
            }
        }
    }
}
