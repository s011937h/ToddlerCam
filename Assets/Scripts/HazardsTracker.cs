using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsTracker : MonoBehaviour {
    protected int _hazards;
	// Use this for initialization
	void Start () {
      _hazards = 0;
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    public void HazardFound()
    {
        _hazards++;
    }
    public int GetHazards()
    {
        return _hazards;
    }
}
