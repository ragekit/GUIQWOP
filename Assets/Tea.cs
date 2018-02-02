using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tea : MonoBehaviour {

	// Use this for initialization
	public string teaName;
	public Color color;
	void Start () {
		
	}
	

	public void Select(bool t){
		if(t == true){
			GetComponent<Image>().color = color;
		} else {
			GetComponent<Image>().color = Color.white;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
