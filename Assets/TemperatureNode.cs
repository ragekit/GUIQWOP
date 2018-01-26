using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class TemperatureNode : UINode {

	// Use this for initialization
	// Update is called once per frame
	public Slider topSlider;
	public Slider bottomSlider;
	public RectTransform matrix;
	public Button validateButton;
	Toggle[] toggles;
    private Toggle[] unoderedToggles;

    void Update () {
		float slidersValue = (topSlider.value + bottomSlider.value) / (topSlider.maxValue + bottomSlider.maxValue);

		int numberOfToggleOn = Mathf.RoundToInt(slidersValue * toggles.Length);

		for (int i = 0; i < unoderedToggles.Length; i++)
		{
		
			unoderedToggles[i].isOn = i<numberOfToggleOn;
		}
	}

	public void success(){
		WhenSucces.Invoke();
		
	}

	override protected void Start(){
		base.Start();
		System.Random rnd = new System.Random();
		toggles = matrix.GetComponentsInChildren<Toggle>();
		unoderedToggles = toggles.OrderBy(x => rnd.Next()).ToArray();
	}
	
	public override void SetSelectable(bool yes){
		topSlider.interactable = bottomSlider.interactable = validateButton.interactable =  yes;
	}
}
