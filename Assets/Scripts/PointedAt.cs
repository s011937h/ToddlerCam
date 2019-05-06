using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;

public class PointedAt : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public HazardsTracker _hazardTracker = null;
    public bool selected;
    // Start is called before the first frame update
    public bool hazardFound;
   
    void Start()
    {
        laserPointer.PointerClick += PointerClicked;
        selected = false;
        hazardFound = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void PointerClicked(object sender, PointerEventArgs e)
    {

       if (e.target.name == gameObject.name && selected == false)
        {
            Debug.Log("Clicked on" + e.target.name);
           if (hazardFound == false)
            {
                _hazardTracker.HazardFound();
                hazardFound = true;
            }
        }
    }
    //public void PointerOutside(object sender, PointerEventArgs e)
    //{

    //    if (e.target.name == this.gameObject.name && selected == true)
    //    {
    //        selected = false;
    //        Debug.Log("pointer is outside this object" + e.target.name);
    //    }
    //}
    public bool get_selected_value()
    {
        return selected;
    }
}