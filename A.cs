using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour {

	public delegate void CollisionEventListener(A a, Collision collision);
	public static event CollisionEventListener OnCollisionWithB;

	public delegate void ColorChangeEventListener(Color newColor);
	public static event ColorChangeEventListener OnColorChange;

	public static void FireColorChange(Color newColor) {
		OnColorChange (newColor);
	}

	void Start () {
		OnColorChange += ChangeColor;
		ChangeColor (Color.blue);
	}

	void ChangeColor(Color newColor) {
		GetComponent<Renderer> ().material.color = newColor;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("BStatic")) {
			OnCollisionWithB (this, collision);
		}
	}

}
