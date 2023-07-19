using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorOrbital : MonoBehaviour
{
    public Transform puntoRotacion;
    public float velocidadRotacion;
    void Update()
    {
        transform.RotateAround(puntoRotacion.position, Vector3.up, velocidadRotacion * Time.deltaTime);
    }
}
