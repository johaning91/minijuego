using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLancha : MonoBehaviour {

    //Variables publicas
    public float velocidad = 7f;
    public float giro = 4f;

    //Variables Privadas
    private Animator animador;
    private Rigidbody jugadorRigibody;
    private Vector3 desplazamiento;

    // Use this for initialization
    void Start() {
        jugadorRigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moverJugador(horizontal, vertical);
    }

    void moverJugador(float horizontal, float vertical)
    {
        desplazamiento.Set(vertical, 0f, horizontal);
        desplazamiento = desplazamiento.normalized * velocidad * Time.deltaTime;
        jugadorRigibody.MovePosition(transform.position + desplazamiento);
        if (horizontal != 0f || vertical != 0f)
        {
            giraJugador(horizontal, vertical);
        } 

    }
    void giraJugador(float horizontal, float vertical)
    {
        Vector3 direccion = new Vector3(horizontal, 0f, vertical);
        Quaternion rotacionJugador = Quaternion.LookRotation(direccion, Vector3.up);
        Quaternion nuevaRotacion = Quaternion.Lerp(GetComponent<Rigidbody>().rotation, rotacionJugador, giro * Time.deltaTime);
        GetComponent<Rigidbody>().MoveRotation(nuevaRotacion);
    }
}
