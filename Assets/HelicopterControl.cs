using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Translate(Vector3.left);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Translate(Vector3.right);

        }

        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Translate(Vector3.forward);

        }

        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.Translate(Vector3.back);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
          
            //Creamos un Gameobject a partir de un prefab (son los planos de un edificio)
            GameObject newMisil = GameObject.Instantiate(Resources.Load("Bullets/Misil") as GameObject);

            // Buscamos el GameObject del pivote de disparo (ShootPivot)

            GameObject shootPivot = GameObject.Find("Helicopter/ShootPivot");

            //Hago el misil hijo de ShootPivot
            newMisil.transform.SetParent(shootPivot.transform);

            //Movemos el misil a la posicion del pivote de disparo
            newMisil.transform.localPosition = Vector3.zero;

            // Sacar el misisl del pivote para que no se mueva con el avion
            newMisil.transform.SetParent(null);


        }
	}
}
