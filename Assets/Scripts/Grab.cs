using UnityEngine;
using Valve.VR;

public class Grab : MonoBehaviour
{
    private SteamVR_Input_Sources hand;

    void Start()
    {
        var pose = GetComponent<SteamVR_Behaviour_Pose>();
        hand = pose.inputSource;
    }

    /*void OnTriggerStay(Collider other)
    {
        Debug.Log("OnCollisionStay()");
        // if trigger down 
        if (GrabPinch(hand))
        {
            Transform grabbedTransform = other.transform;

            // set the parent of the grabbed object to be the controller; 
            // then the object will follow the controller
            grabbedTransform.parent = transform;
        }
    }*/
}
