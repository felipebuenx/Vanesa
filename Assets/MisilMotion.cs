using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward);
	}

    void OnCollisionEnter(Collision collision){
        Debug.Log("Colision entre dos colliders");

        //Destruimos el misil//
        GameObject.Destroy(this.gameObject);

        //Destruimos el enemigo
        GameObject.Destroy(collision.collider.gameObject);

    }
}
