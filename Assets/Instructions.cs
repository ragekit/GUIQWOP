using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Instruction {
	public string text;
	public int minTemp;
	public int maxTemp;
}
public class Instructions : MonoBehaviour {

	// Use this for initialization

	public Instruction[] temperatureInstructions; 

	Instruction currentInstruction;

	void Start () {
		currentInstruction = temperatureInstructions.Random();

		GetComponent<Text>().text = "Can you make me some " + currentInstruction.text + " tea ?";
	}
	
	public void CheckIfWon(){
		int temp = TemperatureNode.instance.getTemperature();
		Debug.Log(temp);
		if(temp < currentInstruction.maxTemp && temp > currentInstruction.minTemp){
			GetComponent<Text>().text = "Thanks, this is some good "+ currentInstruction.text + " tea";
		}else {
			GetComponent<Text>().text = "errr, this tea is not "+ currentInstruction.text + " at all ! ";
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
