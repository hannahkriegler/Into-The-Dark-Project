using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveLaserPointer : MonoBehaviour {

    public Transform controller;

    public int number;
    
    public float radius = 100000.0f;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray raycast = new Ray(controller.transform.position, controller.transform.forward);

        Debug.DrawRay(raycast.origin, raycast.direction * 10000.0f, Color.red);

        RaycastHit hitObject;

        bool rayHit = Physics.Raycast(raycast, out hitObject);
        // Debug.Log(hitObject.point);

        if (rayHit)
        {
            
            GameObject go = hitObject.transform.gameObject;
            //Debug.Log(go.tag);
            if (go.tag == "SusuKamin")
            {
                susuBehaviour susu = go.GetComponent<susuBehaviour>();
                susu.anleuchten(number);
            }
           
            //Debug.Log("getroffen: " + hitObject.transform.gameObject.name);
        }
    }
}