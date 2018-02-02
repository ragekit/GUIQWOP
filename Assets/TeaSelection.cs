using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TeaSelection : UINode
{


    // Use this for initialization
    public Slider slider;
    public RectTransform teaSelectionParent;
    public Tea[] teas;
    // Update is called once per frame
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;


    override protected void Start()
    {
        base.Start();
        teas = teaSelectionParent.GetComponentsInChildren<Tea>();
    }


    float acc;
    float vel;


    void Update()
    {
        //mb make it the last time you dragged it;
        if (isSelectable)
        {


            float accDrag = Mathf.Abs(slider2.value - 0.25f) * Mathf.Abs(slider3.value - 0.75f);

            acc = (Random.value * 2 - 1) * accDrag * 0.1f;
            vel += acc;

            float maxSpeed = (slider1.value + slider4.value) / 10.0f;
            Debug.Log(maxSpeed);

            vel = Mathf.Abs(vel) > maxSpeed ? maxSpeed : vel;

            if (slider.value + vel < 0 || slider.value + vel > 1)
            {
                vel *= -1;
            }
            slider.value += vel;
            selectTea();
        }
    }

    void selectTea()
    {
        float v = slider.value;

        v = (v / slider.maxValue) * teas.Length;
        int i = (int)v;
        for (int j = 0; j < teas.Length; j++)
        {
            if (i == j)
            {
                teas[j].Select(true);
            }
            else
            {
                teas[j].Select(false);
            }
        }



    }
}
