using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlushNode : UINode {

	// Use this for initialization
	public Slider flushMain;
	ClickIncrease[] cis;
	bool flushing;
	// Update is called once per frame
	void Update () {
		if(flushing){
			foreach (var item in cis)
			{
				item.CheckButtons();
			}
			foreach (var item in cis)
			{
				
				if(!item.validated){
					return;
				}
			}
			flushMain.interactable = true;
			if(flushMain.value == 1){
				WhenSucces.Invoke();
				flushing = false;
			}
		}
	}
	// could be change with setselectable
	public void InitiateFlush(){
		//base.SetSelectable(true);
		//flushMain.interactable = false;
		flushing = true;
		flushMain.value = 0;
		cis= GetComponentsInChildren<ClickIncrease>();
		Debug.Log(cis.Length);
		foreach (var item in cis)
		{
			item.Init();
		}
	}
}
