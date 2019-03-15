using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara1 : MonoBehaviour {

    // variables publicas
    public GameObject jugador;
    //public GameObject referencia;

    private Vector3 distancia;
	// Use this for initialization
	void Start () {
        distancia = (transform.position - jugador.transform.position);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = jugador.transform.position + distancia;
        //transform.LookAt(jugador.transform.position);
        //Vector3 copia = new Vector3(0, transform.eulerAngles.y, 0);
        //referencia.transform.eulerAngles = copia;
	}
}
