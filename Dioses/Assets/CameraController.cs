using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
        void Start()
    {
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
    }

    public void CamaraTop()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }
    public void CamaraCubo()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
}