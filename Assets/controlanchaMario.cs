using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlanchaMario : MonoBehaviour {
    public float movHorizontal;
    public float movVertical;
    private Vector3 playerInput;
    public CharacterController jugador;

    public float velocidadJugador;
    private Vector3 movPlayer; 
    public Camera mainCamera;
    private Vector3 camDelante;
    private Vector3 camDerecha;


    // Use this for initialization
    void Start () {
        jugador = GetComponent<CharacterController>(); 

    }
	
	// Update is called once per frame
	void Update () {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");
        playerInput = new Vector3(movHorizontal,0,movVertical);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);
        camDirection();
        movPlayer = playerInput.x * camDerecha + playerInput.z * camDelante;
        jugador.transform.LookAt(jugador.transform.position + movPlayer);
        jugador.Move(movPlayer * velocidadJugador * Time.deltaTime);


    }
    void camDirection()
    {
        camDelante = mainCamera.transform.forward;
        camDerecha = mainCamera.transform.right;
        camDelante.y = 0;
        camDerecha.y = 0;
        camDelante = camDelante.normalized;
        camDerecha = camDerecha.normalized;
    } 
    
}
