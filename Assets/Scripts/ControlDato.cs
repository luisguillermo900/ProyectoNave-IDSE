using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDato : MonoBehaviour
{
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (rigidbody == null)
        {
            Debug.LogError("Rigidbody no encontrado!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime + " seg. " + (1.0f / Time.deltaTime) + " FPS");
        ProcesarInput();
    }

    private void ProcesarInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Propulsor");
            rigidbody.AddRelativeForce(Vector3.up * 10f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotar Derecha");
            var rotarD = transform.rotation;
            rotarD.x += Time.deltaTime / 2;
            transform.rotation = rotarD;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotar Izquierda");
            var rotarI = transform.rotation;
            rotarI.x -= Time.deltaTime / 2;
            transform.rotation = rotarI;
        }
    }
}
