using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class BrewTimeNode : UINode {

	// Use this for initialization
	public Button button;
	Led[] children;
	Led[] randomChildren;

	int index;

	public float time;
	public static BrewTimeNode instance;
	// Update is called once per frame
	void Update () {
		
	}

	void OnclickButton(){
	
		if(index == randomChildren.Length){
			index = 0;
			foreach (var item in randomChildren)
			{
				item.Off();
			}
		}else {
	randomChildren[index].On();
		index += 1;
	
		}

		time = index *10;
	}

	override public void SetSelectable(bool yes){
		button.interactable = yes;
		base.SetSelectable(yes);
	}

	override protected void Start(){
		base.Start();
		instance = this;
		children = GetComponentsInChildren<Led>();
		System.Random rnd = new System.Random();
		randomChildren = children.OrderBy(x => rnd.Next()).ToArray();    
		button.onClick.AddListener(OnclickButton);
	}
}
