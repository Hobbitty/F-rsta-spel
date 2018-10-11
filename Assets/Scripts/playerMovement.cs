using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //sätter värden för framåt och roteringshastighet
    public float forward;
    public float rotate;
    private float time;
  



    void Start()
    {
        //radomiserar floaten för hur snabbt skeppet ska åka framåt.
        forward = (Random.Range(0, 5f));
        InvokeRepeating("rotateBasedOnTime", 1f, 1f);
    }
    
    void Update()
    {
        movement();
    }
    void movement()
    {
        //sätter Kontrollerna för spelet samt vad varje kanpp gör
        if (Input.GetKey(KeyCode.A))
        {
            // roterar spriten med värdet "rotate" och multiplicerar det med time.deltatime. 
            //delar rotate med 2 för att göra vänstersvängar långsammare.
            transform.Rotate(0, 0, (rotate/2)*Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            //pushar spriten bakåt med hälften av kraften som den trycks fram med. Därav saktas den ner till halva hastigheten.

            transform.Translate(0, (forward/2)*Time.deltaTime, 0, Space.Self);

        }
        if (Input.GetKey(KeyCode.D))
        {
            // roterar spriten med värdet "rotate" och multiplicerar det med time.deltatime. 

            transform.Rotate(0, 0, -rotate*Time.deltaTime, Space.Self);
        }
        //Tryker ständigt fram spriten med forward variablen
        transform.Translate(0, forward*Time.deltaTime, 0, Space.Self);
    }
    void rotateBasedOnTime()
    {
        time += 1;
        rotate += time / 5;
    }
}
