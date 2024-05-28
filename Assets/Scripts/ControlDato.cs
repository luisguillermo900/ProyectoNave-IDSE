using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDato : MonoBehaviour
{
    private Rigidbody rigidbody;
    private AudioSource audioSource;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (rigidbody == null)
        {
            Debug.LogError("Rigidbody no encontrado!");
        }
        if (audioSource == null)
        {
            Debug.LogError("Audio Source no encontrado!");
            audioSource = GetComponent<AudioSource>();
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
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else { 
                audioSource.Stop();
            }
            
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
