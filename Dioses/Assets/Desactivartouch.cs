using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivartouch : MonoBehaviour
{
    public GameObject desactivartouch;

   void Start()
    {
        
    }
    public void Desactivarcamaracubo()
    {
        desactivartouch.GetComponent<CameraMovement>().enabled = false;
    }
    public void Activarcamaracubo()
    {
        desactivartouch.GetComponent<CameraMovement>().enabled = true;
    }
    public void Desactivarcamaratop()
    {
        desactivartouch.GetComponent<PanZoom>().enabled = false;
    }
    public void Activarcamara()
    {
        desactivartouch.GetComponent<PanZoom>().enabled = true;
    }
}
