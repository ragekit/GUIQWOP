using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class MainButton : MonoBehaviour {

	// Use this for initialization
	public UnityEvent WhenOn;
	public UnityEvent WhenOff;
	Toggle t;
	
	// Update is called once per frame
	void Start(){
		t = GetComponent<Toggle>();
	}

	void Update () {
		if(t.isOn){
			WhenOn.Invoke();
		}else {
			WhenOff.Invoke();
		}
	}

}
