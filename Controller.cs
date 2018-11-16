using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public Slider aSlider;
	public Slider bSlider;
	public Slider cSlider;
	
	// Use this for initialization
	void Start () {
		A.OnCollisionWithB += OnACollisionWithB;
		aSlider.onValueChanged.AddListener (delegate {
			A.FireColorChange(new Color(aSlider.value, aSlider.value, aSlider.value));
		});
		bSlider.onValueChanged.AddListener (delegate {
			B.FireColorChange(new Color(bSlider.value, bSlider.value, bSlider.value));
		});
		cSlider.onValueChanged.AddListener (delegate {
			C.FireColorChange(new Color(cSlider.value, cSlider.value, cSlider.value));
		});
	}

	void OnACollisionWithB(A a, Collision collision) {
		A.FireColorChange (Random.ColorHSV(0, 1));
		C.FireMassChange (new Vector3(0.1f, 0.1f, 0.1f));
	}
}
