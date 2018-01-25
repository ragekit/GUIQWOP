using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class PowerNode : UINode {

	// Use this for initialization

	// Update is called once per frame

	public Toggle button;
	public UnityEvent WhenRunning;
	public UnityEvent WhenOff;
	void Update () {
		if(button.isOn){
			WhenRunning.Invoke();
		}else {
			WhenOff.Invoke();
		}
	}

	public void valueChanged(bool value){
		if(!value){
			WhenFail.Invoke();
		} else {
			WhenSucces.Invoke();
		}
	}
}
