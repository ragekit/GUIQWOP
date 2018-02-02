using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ticker : MonoBehaviour {

	// Use this for initialization
	
	public Button button;
	public Image ticker;
	public Color PingColor;
	public Color validateColor;

	public bool isTicking;
	public bool isLocked;
	
	void Start () {
		button.onClick.AddListener(onClick);
	}

	public void Ping(float time){
		
		StartCoroutine(ping(time));
	}

	public void SetLocked(){
		if(isTicking){
			StopAllCoroutines();
			ticker.color = validateColor;
			isLocked = true;
		}

		
	}

	void onClick(){
		SetLocked();
	}

	IEnumerator ping(float t){
		Color d = ticker.color;
		isTicking = true;
		ticker.color = PingColor;
		yield return new WaitForSeconds(t);
		isTicking = false;
		ticker.color = d;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
