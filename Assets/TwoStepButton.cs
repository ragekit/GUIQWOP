using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TwoStepButton : Button {

    // Use this for initialization
    private bool validated;
    public Color validatedColor;
    public Color OnColor;
    public UnityEvent OnValueChangeSecondTime;

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
                Debug.Log("second time");
                interactable = false;
                ColorBlock c = colors;
                c.disabledColor = Color.white;
                colors = c;

                targetGraphic.color = validatedColor;
			}
        }
    }

    private int changedTime;

    private void onValueChangedInternal(){
        changedTime += 1;
        if(changedTime == 1){
            targetGraphic.color = OnColor;
        }
        if(changedTime == 2){
            
            OnValueChangeSecondTime.Invoke();
        }
    }

    override protected void Start(){
        base.Start();
        onClick.AddListener(onValueChangedInternal);
    }

    // Update is called once per frame
    void Update () {
       
	}
}
