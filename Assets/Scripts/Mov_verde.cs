using UnityEngine;
using System.Collections;

public class Mov_verde : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 1f;
	public float vertical = 15f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			rb.AddForce (transform.up*vertical);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			rb.AddForce (transform.up*-vertical);
		}
	}
}