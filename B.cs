using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour {

	public delegate void ColorChangeEventListener(Color newColor);
	public static event ColorChangeEventListener OnColorChange;

	public static void FireColorChange(Color newColor) {
		OnColorChange (newColor);
	}

	// Use this for initialization
	void Start () {
		OnColorChange += ChangeColor;
		ChangeColor (Color.red);
	}

	void ChangeColor(Color newColor) {
		GetComponent<Renderer> ().material.color = newColor;
	}
}
