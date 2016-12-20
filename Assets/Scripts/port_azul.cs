using UnityEngine;
using System.Collections;


public class port_azul : MonoBehaviour {

	private Rigidbody2D rb;
	GameObject puntosverde;
	Punt_azul pa;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		puntosverde = GameObject.Find ("puntosverde");
		pa = puntosverde.GetComponent<Punt_azul> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Bola") {
			pa.suma_puntos (1);
		}
	}
}

