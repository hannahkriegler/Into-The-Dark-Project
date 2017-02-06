using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class susuBehaviourBildBackRight : MonoBehaviour {

    Animator anim;
    GameManager gameManager;
    public bool player1 = false;
    public bool player2 = false;

    // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animator>();
        gameManager = this.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player1 && player2)
        {
            Debug.Log("SusuBild wird von beiden angeleuchtet");
            vergluehen();
        }
        if (!(player1 || player2)) anim.SetBool("anleuchten", false);
        player1 = false;
        player2 = false;

    }

    public void anleuchten(int number)
    {
        Debug.Log("SusuBild wird von " + number + " angeleuchtet");
        anim.SetTrigger("erschrecken");
        anim.SetBool("anleuchten", true);
        if (number == 1) player1 = true;
        else player2 = true;
    }

    public void vergluehen()
    {
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

    public void kill()
    {
        Destroy(this.gameObject);
    }
}
