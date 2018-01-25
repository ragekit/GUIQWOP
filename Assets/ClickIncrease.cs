using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickIncrease : MonoBehaviour {

	// Use this for initialization

	public Button button;
	public Scrollbar scrollbar;
	public bool validated;
	void Start () {
	}

	public void Init(){
		button.interactable = true;
		validated = false;
	}
	
	public void buttonclicked(bool yes){
		if(!validated){
			if(yes){
				scrollbar.size += 0.01f;
			}else {
				if(scrollbar.size > 0 && !validated){
					scrollbar.size -= 0.01f;
					
				}else if(scrollbar.size <0){
					scrollbar.size =0;
				}
			}
			
			if(scrollbar.size >= 1){
				validated = true;
			}
		}	
	}
	

	// Update is called once per frame
	void Update () {

		
	}
}
