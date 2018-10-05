using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangerScript : MonoBehaviour {
    public SpriteRenderer Rend;
    private float red;
    private float green;
    private float blue;

	void Start () {
		
	}
	

	void Update ()
    {
        randomColor();
	}

    void randomColor()
    {
        //gör så att ifall space blir nedtryckt ändras färgen 1 gång 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //randomiserar värderna på RGB varje gång space är nedtryckt så att det blir olika varje gång
            red = (Random.Range(0, 1f));
            green = (Random.Range(0, 1f));
            blue = (Random.Range(0, 1f));
            //sätter färgen. Sätter 1f i slutet för att hålla alphan 100%
            Rend.color = new Color(red, green, blue, 1f);
        }
    }
}
