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
	void Update () {
		if(IsPressed()){
			WhenPressed.Invoke();
		}else {
			NotPressed.Invoke();
		}
	}


}
