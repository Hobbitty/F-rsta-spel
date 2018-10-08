using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
    public Transform player;
    public TrailRenderer trail;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        warp();
	}
    void warp()
    {   // ifall spriten åker utanför skärmen (6 x rutor)
        if (transform.position.x > 6)
        {//flytta spriten till -6 rutor och behåll samma y och z värde
            transform.position = new Vector3(-6f, transform.position.y, transform.position.z);
        }//ifall spriten åker utanför skärmen (-6)
        if (transform.position.x < -6)
        {//flytta spelaren till 6 rutor och behåll samma y och z värde
            transform.position = new Vector3(6f, transform.position.y, transform.position.z);
        }//samma som ovan fast med y värde istället
        if (transform.position.y > 6)
        {// --||--
            transform.position = new Vector3(transform.position.x, -6 , transform.position.z);
        }//--||--
        if (transform.position.y < -6)
        {// --||--
            transform.position = new Vector3(transform.position.x, 6f, transform.position.z);
        }

    }
}
