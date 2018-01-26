using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TwoStepToggle : Toggle {

    // Use this for initialization
    private bool validated;
    public Color validatedColor;

    public bool Validated
    {
        get
        {
            return validated;
        }

        set
        {
            validated = value;
			if(validated == true){
				graphic.color = validatedColor;
				interactable = false;
			}
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
