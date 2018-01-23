using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class PowerSlider : MonoBehaviour {
	Slider s;
	public UnityEvent OnEmpty;
	public UnityEvent OnFull;
	public float speed;
	// Use this for initialization
	void Start () {
		s = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {


		if(s.value <= 0){
			OnEmpty.Invoke();
		}else if(s.value == 1){
			OnFull.Invoke();
		}


	}

	public void Decrease(){
		s.value -= speed;
	}

	
}
