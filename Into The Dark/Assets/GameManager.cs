using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    int counter = 0;
    
    

	// Use this for initialization
	void Start () {
		
        foreach (Display dis in Display.displays)
        {
            dis.Activate();
        }

       
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    public void setCounter()
    {
        counter++;
    }
}
