using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class cronometro : MonoBehaviour {

    
    public Text tiempo;
    private float time = 0f;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        tiempo.text = ""+time.ToString("f2")+"s";
	}
    void iniciar()
    {
        
    }

}
