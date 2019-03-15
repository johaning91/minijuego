using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vueltas : MonoBehaviour {

    public GameObject jugador;
    // Use this for initialization
    public Text textovueltas;
    private int completas = 0;
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        
        completaVuenta();
	}
    void completaVuenta()
    {
        
        if ((jugador.transform.position.x < -2.4 && jugador.transform.position.x > -2.68)  && (jugador.transform.position.z > -19 && jugador.transform.position.z < -3))
        {
            completas++;
            textovueltas.text = completas.ToString() ;
        }
    }
}
