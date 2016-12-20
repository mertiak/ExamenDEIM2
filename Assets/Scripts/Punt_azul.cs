using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Punt_azul : MonoBehaviour {

	private int puntos = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
		suma_puntos (0);
	}
	public void suma_puntos(int cantidad){
		puntos = puntos + cantidad;
		if (puntos < 0) {
			puntos = 0;
		}
		texto.text = puntos.ToString ();

	}

}

