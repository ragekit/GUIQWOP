using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
using UnityEngine.Events;
public class TemperatureNode : UINode {

	// Use this for initialization
	// Update is called once per frame
	public RectTransform matrix;
	Toggle[] toggles;

	[HideInInspector]
	public static TemperatureNode instance;
    private BitArray bits;

	public Scrollbar feedback;

    void Update () {

	}

	public float getTemperature(){
		for (int j = 0; j < toggles.Length; j++)
		{
			bits[j] = toggles[j].isOn;
		}
		return getTempFromBitArray(bits);
	}

	public void changeTemperature(){
		for (int j = 0; j < toggles.Length; j++)
		{
			bits[j] = toggles[j].isOn;
		}
		Debug.Log(getTempFromBitArray(bits));

		feedback.size = getTempFromBitArray(bits)/100.0f;
	}

	private float getTempFromBitArray(BitArray bitArray)
	{
		long value = 0;

		Debug.Log(bitArray.Count);
		for (int i = 0; i < bitArray.Count; i++)
		{
			if (bitArray[i])
				value += (long)Mathf.Pow(2, bitArray.Count-i -1);
		}
		double maxvalue = System.Math.Pow(2,8) -1;
		return  (float)((value/maxvalue)*100);
	}

	public void success(){
		WhenSucces.Invoke();
		
	}

	override protected void Start(){
		base.Start();
		instance = this;
		toggles = matrix.GetComponentsInChildren<Toggle>();
		bits = new BitArray(toggles.Length);

		foreach (var item in toggles)
		{
			item.onValueChanged.AddListener(delegate{changeTemperature();});
		}
	}
	
}
