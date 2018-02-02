using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Led : MonoBehaviour {

	// Use this for initialization
	Image i;
	public Color onColor;
	void Start () {
		i = GetComponent<Image>();
	}
	
	public void On(){
		i.color = onColor;
	}

	public void Off(){
		i.color = Color.white;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
