using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ExtendedButton : Button {

	// Use this for initialization
	public UnityEvent WhenPressed;
	public UnityEvent NotPressed;
	// Update is called once per frame
	public bool pressed;
	void Update () {
		if(IsPressed()){
			WhenPressed.Invoke();
			pressed = true;
		}else {
			NotPressed.Invoke();
			pressed = false;
		}
	}


}
