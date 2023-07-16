using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasManager : MonoBehaviour
{
    public List<GameObject> cameras;
    void Start()
    {
        ActivateCamera(0);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ActivateCamera(0);
        }else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ActivateCamera(1);
        } else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ActivateCamera(2);
        } else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            ActivateCamera(3);
        } else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            ActivateCamera(4);
        }
    }
    void ActivateCamera(int activeCamera)
    {
        foreach (var cam in cameras)
        {
            cam.SetActive(false);
        }
        cameras[activeCamera].SetActive(true);
    }
}
