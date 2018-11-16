using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour {

	public delegate void ColorChangeEventListener(Color newColor);
	public static event ColorChangeEventListener OnColorChange;

	public static void FireColorChange(Color newColor) {
		OnColorChange (newColor);
	}

	public delegate void MassChangeEventListener(Vector3 scale);
	public static event MassChangeEventListener OnMassChange;
	
	public static void FireMassChange(Vector3 scale) {
		OnMassChange (scale);
	}
	
	void Start () {
		OnMassChange += ChangeMass;
		OnColorChange += ChangeColor;
		ChangeColor (Color.black);
	}

	void ChangeMass(Vector3 scale) {
		GetComponent<Transform> ().localScale += scale;
	}

	void ChangeColor(Color newColor) {
		GetComponent<Renderer> ().material.color = newColor;
	}

}
