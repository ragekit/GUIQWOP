using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddWater : UINode {

	// Use this for initialization
	public Slider[] sliders;
	public Scrollbar waterLevel;
	float overfill;
	bool canOverfill;
	public override void SetSelectable(bool yes){
		foreach (var item in sliders)
		{
			item.value = 0;
		}
		waterLevel.size = 0;

		base.SetSelectable(yes);
		waterLevel.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(TestSliders()){
			waterLevel.size += 0.01f;
			
		}

		if(waterLevel.size >=1 && canOverfill){
				overfill += Time.deltaTime;

				if(overfill >= 2){
					fail();
				}
		}
	}

	
	void success(){
		WhenSucces.Invoke();
		canOverfill = false;
	}
	void fail(){
		WhenFail.Invoke();
		overfill = 0;
		canOverfill = false;
	}
	bool TestSliders(){
		foreach (var item in sliders)
		{
			if(item.value < item.maxValue/2 - 0.1f ||item.value > item.maxValue/2 + 0.1f){
				
				return false;
			}
		}
		return true;
	}

	public void ButtonClicked(){
		if(waterLevel.size <1){
			fail();
			return;
		}
		success();
	}
}
