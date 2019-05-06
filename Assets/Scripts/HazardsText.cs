using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HazardsText : MonoBehaviour
{
    public HazardsTracker _hazardTracker = null;
    private TextMeshPro hazardText;
	// Use this for initialization
	void Start ()
    {
        hazardText = GetComponent<TextMeshPro>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        hazardText.text = ("Hazards found: " + _hazardTracker.GetHazards() + " Hazards total: 6");
        
    }
}
