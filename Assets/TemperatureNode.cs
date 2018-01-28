using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class TemperatureNode : UINode {

	// Use this for initialization
	// Update is called once per frame
	public Slider topSlider;
	public Slider bottomSlider;
	public RectTransform matrix;
	public Button validateButton;
	Toggle[] toggles;
    private Toggle[] unoderedToggles;

	[HideInInspector]
	public static TemperatureNode instance;
    private BitArray bits;

    void Update () {
		float slidersValue = (topSlider.value + bottomSlider.value) / (topSlider.maxValue + bottomSlider.maxValue);

		int numberOfToggleOn = Mathf.RoundToInt(slidersValue * toggles.Length);
		
		

		for (int i = 0; i < unoderedToggles.Length; i++)
		{
			unoderedToggles[i].isOn = i<numberOfToggleOn;
			
		}

		for (int j = 0; j < toggles.Length; j++)
		{
			bits[j] = toggles[j].isOn;
		}
	
	}

	public int getTemperature(){
		return getTempFromBitArray(bits);
	}

	private int getTempFromBitArray(BitArray bitArray)
	{
		long value = 0;

		
		for (int i = 0; i < bitArray.Count; i++)
		{
			if (bitArray[i])
				value += (long)Mathf.Pow(2, bitArray.Count-i -1);
		}
		double intdiff = (double)((long)(int.MaxValue) - (long)(int.MinValue));
		return  (int)((value/intdiff)*100);
	}

	public void success(){
		WhenSucces.Invoke();
		
	}

	override protected void Start(){
		base.Start();
		instance = this;
		System.Random rnd = new System.Random();
		toggles = matrix.GetComponentsInChildren<Toggle>();
		bits = new BitArray(toggles.Length);
		unoderedToggles = toggles.OrderBy(x => rnd.Next()).ToArray();
	}
	
	public override void SetSelectable(bool yes){
		topSlider.interactable = bottomSlider.interactable = validateButton.interactable =  yes;
	}
}
