using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveLaserPointer : MonoBehaviour {

    public Transform controller;

    public int number;
    
    public enum AxisType
    {
        XAxis,
        ZAxis
    }

    
    public Color color;
    public float thickness = 5000.0f;
    public AxisType facingAxis = AxisType.XAxis;
    public float length = 100f;
    public bool showCursor = true;

    GameObject holder;

    private GameObject hitPrimitive;

    // Use this for initialization
    void Start()
    {
   
    }

    void Update()
    {
        Ray raycast = new Ray(controller.transform.position, controller.transform.forward);


        Debug.DrawRay(raycast.origin, raycast.direction * 10000.0f, Color.red);


        RaycastHit hitObject;
        bool rayHit = Physics.Raycast(raycast, out hitObject);
        

        if (rayHit)
        {
            GameObject go = hitObject.transform.gameObject;
            Debug.Log(go.tag);
            if (go.tag == "SusuKamin")
            {
                susuBehaviour susu = go.GetComponent<susuBehaviour>();
                susu.anleuchten(number);
            }
           
            Debug.Log("getroffen: " + hitObject.transform.gameObject.name);
        }
    }
}
