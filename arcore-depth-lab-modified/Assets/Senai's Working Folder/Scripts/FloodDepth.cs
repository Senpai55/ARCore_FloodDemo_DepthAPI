using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class FloodDepth : MonoBehaviour
{
    //dynamic float that is updated by slider value
    public float waterGridHeight;

    //slider that enables changing flood level
    public Slider floodLevelSlider;

    //gameobject controlling rain particles
    public GameObject rain;

    //set water grid height
    public void SetDepth(float value)
    {           
        //update flood height based on slider value 
        //which can then be passed into the WaterGridManager script to update WaterDepthInM value
        waterGridHeight = value;
    }

    public void Flood()
    {
        //increase rain
        rain.SetActive(true);

        //raise flood level over 5 seconds
        floodLevelSlider.DOValue(floodLevelSlider.maxValue, 5);
    }

    public void Drain()
    {
        //stop rain
        rain.SetActive(false);

        //lower flood level over 5 seconds
        floodLevelSlider.DOValue(floodLevelSlider.minValue, 5);
    }
}
