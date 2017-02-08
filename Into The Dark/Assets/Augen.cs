using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Augen : MonoBehaviour {

    public Material black;
    public Material white;
    SpriteRenderer auge;
    public bool visible;
	// Use this for initialization
	void Start () {
        auge = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	   	}

    public void makeWhite()
    {
        auge.material = white;
    }

    public void makeBlack()
    {
        auge.material = black;
    }
}
