using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float velocidadMinima = 10;
    public float velocidadMaxima = 100;

    public float incrementoVelocidad = 0.1f;
    public float velocidadGiro = 10f;
    public float velocidadInclinacion = 10f;

    public float velocidad;
 
    float x = 0;
    float y = 0;

    private void Start()
    {
        velocidad = velocidadMinima;
    }

    void Update()
    {
        transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);
        GestionarAceleracion();
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(
            new Vector3(
            y * velocidadInclinacion * Time.deltaTime, 
            x * velocidadGiro * Time.deltaTime, 
            0),
            Space.Self);
    }

    private void GestionarAceleracion()
    {
        if (Input.GetKey(KeyCode.E))
        {
            velocidad += incrementoVelocidad;
            velocidad = Mathf.Min(velocidad, velocidadMaxima);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            velocidad -= incrementoVelocidad;
            velocidad = Mathf.Max(velocidad, velocidadMinima);
        }
    }
}
