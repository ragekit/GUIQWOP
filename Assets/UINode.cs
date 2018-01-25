using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class UINode : MonoBehaviour {

	// Use this for initialization

	public UnityEvent WhenFail;
	public UnityEvent WhenSucces;
	public bool initSelectable;
	Selectable[] selectableContent;
	void Start () {
		selectableContent = GetComponentsInChildren<Selectable>();
		SetSelectable(initSelectable);
	}
	
	public virtual void SetSelectable(bool yes){
		foreach (var item in selectableContent)
		{
			item.interactable = yes;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
