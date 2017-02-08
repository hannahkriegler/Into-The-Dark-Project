using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class susuBehaviour : MonoBehaviour {

    Animator anim;
    GameManager gameManager;
    public bool player1 = false;
    public bool player2 = false;

   AudioSource[] sounds;
    public AudioSource erschrecken;
    public AudioSource giggle1;
    Augen augen;

    // Use this for initialization
    void Start () {
        anim = this.GetComponent<Animator>();
        gameManager = this.GetComponent<GameManager>();
        sounds = this.GetComponents<AudioSource>();
        erschrecken = sounds[0];
        giggle1 = sounds[1];
        augen = this.GetComponentInChildren<Augen>();
	}
	
	// Update is called once per frame
	void Update () {

        if (player1 && player2)
        {
            Debug.Log("Susu wird von beiden angeleuchtet");
            vergluehen();
            
        }
	    if (! (player1 || player2)) anim.SetBool("anleuchten", false);
        player1 = false;
        player2 = false;
        augen.makeBlack();
    }
    
    public void anleuchten(int number)
    {
        augen.makeWhite();
        Debug.Log("Susu wird von " + number + " angeleuchtet");
        erschrecken.Play();
        anim.SetTrigger("erschrecken");
        anim.SetBool("anleuchten", true);
        
        if (number == 1) player1 = true;
        else player2 = true;
    }

    public void vergluehen()
    {
        giggle1.Play();
        anim.SetTrigger("vergluehen");   
    }

    public void setPlayer1()
    {
        player1 = false;
    }
    public void setPlayer2()
    {
        player2 = false;
    }

    public void kill() {
        Destroy(this.gameObject);
    }
}
