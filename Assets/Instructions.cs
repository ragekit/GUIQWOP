using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Instruction
{
    public string text;
	public override string ToString()
    {
		return text;
	}
	
}
[System.Serializable]
public class TemperatureInstruction : Instruction
{
    public int minTemp;
    public int maxTemp;
}
[System.Serializable]
public class FilterInstruction : Instruction
{
    public bool yes;
}
[System.Serializable]
public class TeaInstruction : Instruction
{
    public string tea;
}
[System.Serializable]
public class TimeInstruction : Instruction
{
    public int time;
}

public class InstructionSet : IEnumerable
{

    public TimeInstruction time;
    public TeaInstruction tea;
    public FilterInstruction filter;
    public TemperatureInstruction temperature;
    public InstructionSet(TemperatureInstruction temp, TimeInstruction t, TeaInstruction tea, FilterInstruction filter)
    {
        this.time = t;
        this.tea = tea;
        this.filter = filter;
        this.temperature = temp;
    }

    public IEnumerator GetEnumerator()
    {
        yield return time;
        yield return tea;
        yield return filter;
        yield return temperature;
    }
}


public class Instructions : MonoBehaviour
{

    // Use this for initialization

    public TemperatureInstruction[] temperatureInstructions;
    public TimeInstruction[] timeInstruction;
    public TeaInstruction[] teaInstruction;
    public FilterInstruction[] filterInstruction;

    InstructionSet currentInstructions;

    void Start()
    {

        currentInstructions = new InstructionSet(
            temperatureInstructions.Random(),
            timeInstruction.Random(),
            teaInstruction.Random(),
            filterInstruction.Random()
        );


        GetComponent<Text>().text = "Can you make me some " +
        currentInstructions.temperature + " " +
        currentInstructions.tea + " tea, brewed " +
        currentInstructions.time + " " +
        currentInstructions.filter;


    }

    public void CheckIfWon()
    {
        float temp = TemperatureNode.instance.getTemperature();
		string tea = TeaSelection.instance.tea;
		bool clean = CleanWaterNode.instance.cleanRatio > 0.5f;
		float time = BrewTimeNode.instance.time;

		string retText = "";

		if(tea != currentInstructions.tea.tea){
			retText += "this is not " + currentInstructions.tea.tea + " tea !! ";
		}

		if(clean != currentInstructions.filter.yes){
			retText += "The water taste funny ";
		}

		if(temp < currentInstructions.temperature.minTemp || temp > currentInstructions.temperature.maxTemp){
			retText += "It is not even" + currentInstructions.temperature.text + " !! ";
		}

		if(time < currentInstructions.time.time -30){
			retText += "it's clearly not infused enought ";
		}
		if(time > currentInstructions.time.time +30){
			retText += "wow, it's way too bitter";
		}

		GetComponent<Text>().text = retText;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
