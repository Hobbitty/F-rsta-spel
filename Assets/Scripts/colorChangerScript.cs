using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangerScript : MonoBehaviour
{
    public SpriteRenderer Rend;
    public float red;
    public float green;
    public float blue;
    public bool pulseBoolRed;
    public bool pulseBoolGreen;
    public bool pulseBoolBlue;

    void Start()
    {

    }


    void Update()
    {
        randomColor();
    }

    void randomColor()
    {
        //gör så att ifall space blir nedtryckt ändras färgen 1 gång 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("pulse", 0.07f, 0.07f);
            //randomiserar värderna på RGB varje gång space är nedtryckt så att det blir olika varje gång
            red = (Random.Range(0, 1f));
            green = (Random.Range(0, 1f));
            blue = (Random.Range(0, 1f));
            //sätter färgen. Sätter 1f i slutet för att hålla alphan 100%
            Rend.color = new Color(red, green, blue, 1f);
            if (red < 0.5)
            {
                pulseBoolRed = false;
            }
            if (red > 0.5)
            {
                pulseBoolRed = true;
            }
            if (green < 0.5)
            {
                pulseBoolGreen = false;
            }
            if (green > 0.5)
            {
                pulseBoolGreen = true;
            }
            if (blue < 0.5)
            {
                pulseBoolBlue = false;

            }
            if (blue > 0.5)
            {
                pulseBoolBlue = true;
            }
        }

    }
    void pulse()
    {
        if (pulseBoolRed == false)
        {
            red -= 0.05f;
            if (red < 0)
            {
                red = 0;
            }
            if (red == 0)
            {
                pulseBoolRed = true;
            }
            Rend.color = new Color(red, green, blue, 1f);
        }
        if (pulseBoolRed == true)
        {
            red += 0.05f;
            if (red > 1)
            {
                red = 1;
            }
            if (red == 1)
            {
                pulseBoolRed = false;
            }
            Rend.color = new Color(red, green, blue, 1f);
        }

        if (pulseBoolGreen == false)
        {
            green -= 0.05f;
            if (green < 0)
            {
                green = 0;
            }
            if (green == 0)
            {
                pulseBoolGreen = true;
            }
            Rend.color = new Color(red, green, blue, 1f);
        }
        if (pulseBoolGreen == true)
        {
            green += 0.05f;
            if (green > 1)
            {
                green = 1;
            }
            if (green == 1)
            {
                pulseBoolGreen = false;
            }
            Rend.color = new Color(red, green, blue, 1f);
        }

        if (pulseBoolBlue == false)
        {
            blue -= 0.05f;
            if (blue < 0)
            {
                blue = 0;
            }
            if (blue == 0)
            {
                pulseBoolBlue = true;
            }
            Rend.color = new Color(red, green, blue, 1f);
        }
        if (pulseBoolBlue == true)
        {
            blue += 0.05f;
                if (blue >1)
            {
                blue = 1;
            }
                if (blue == 1)
            {
                pulseBoolBlue = false;
            }
        }
        
    }
}
