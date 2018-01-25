using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddWater : UINode {

	// Use this for initialization
	public Slider[] sliders;


	public override void SetSelectable(bool yes){
		foreach (var item in sliders)
		{
			item.value = 0;
		}


		base.SetSelectable(yes);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonClicked(){
		foreach (var item in sliders)
		{
			Debug.Log(item.value);
			if(item.value < item.maxValue/2 - 0.1f ||item.value > item.maxValue/2 + 0.1f){
				WhenFail.Invoke();
				Debug.Log("fail");
				return;
			}
		}
		WhenSucces.Invoke();
	}
}
