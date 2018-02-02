using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CleanWaterNode : UINode
{

    // Use this for initialization

    // Update is called once per frame



    Ticker[] ticks;
	List<Ticker> notTicking;
	List<Ticker> notLocked;

	public RectTransform outputParent;
	Image[] outputs;
	public Color outputColor;

	public float cleanRatio;
	public static CleanWaterNode instance;
    void Update()
    {
		
		
    }


	IEnumerator makeTick(){
		while(notLocked.Count > 0 ){
			Ticker r = pickRandom();
			if(r != null){
				r.Ping(1f);
			}
			yield return new WaitForSeconds(1.1f);
		}
		StartCoroutine(growOutput());
	}

	IEnumerator checkFinish(){


		while(notLocked.Count > 0){
			for (int i = 0; i < ticks.Length; i++)
			{
				Ticker item = ticks[i];
				
				if(!item.isTicking && !notTicking.Contains(item)){
					notTicking.Add(item);
				}
				if(item.isLocked){
					notTicking.Remove(item);
					notLocked.Remove(item);
				}
			}
			yield return null;
		}
		StopAllCoroutines();
		StartCoroutine(growOutput());
	}

	IEnumerator growOutput(){
		for (int i = 0; i < outputs.Length; i++)
		{
			Image current = outputs[i];
			current.color = outputColor;
			cleanRatio = (i+1.0f) / outputs.Length;
			yield return new WaitForSeconds(1f);
		}
	}

	Ticker pickRandom (){
		Ticker r;

		if(notTicking.Count >0){
			r = notTicking.Random();
			notTicking.Remove(r);
			return r;
		}
	
		return null;
	}

		public override void SetSelectable(bool yes){
			base.SetSelectable(yes);
			if(yes){
				StartCoroutine(checkFinish());
				StartCoroutine(makeTick());
			}else{
				StopAllCoroutines();
			}
		}

    override protected void Start()
    {
        
		ticks = GetComponentsInChildren<Ticker>();
		notTicking = new List<Ticker>();
		notTicking.AddRange(ticks);
		notLocked = new List<Ticker>();
		notLocked.AddRange(ticks);
		instance = this;
		outputs = outputParent.GetComponentsInChildren<Image>();

		base.Start();
    }
}
