using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StepsButtons : UINode {

	// Use this for initialization

	TwoStepButton[] steps;
	// Update is called once per frame
	void Update () {
		
		if(checkSteps()){
			Success();
		}
	}

    private bool checkSteps()
    {
        foreach (var item in steps)
		{
			if(!item.Validated) return false;
		}
		return true;
    }

    override protected void Start(){
		base.Start();
		steps = GetComponentsInChildren<TwoStepButton>();

	}

	public void Success(){
		WhenSucces.Invoke();
	}
}
