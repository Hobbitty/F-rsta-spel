using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColor : MonoBehaviour {
    public SpriteRenderer Rend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        changecolor();	
	}
    void changecolor()
    {
        //ifall d trycks ner ändras färgen till grön
        if (Input.GetKey(KeyCode.D))
        {
            Rend.color = new Color(0, 0, 1f);
        }
        //ifall A trycks ner ändras färgen till blå
        if (Input.GetKey(KeyCode.A))
        {
            Rend.color = new Color(0, 1f, 0);
        }
    }
}
