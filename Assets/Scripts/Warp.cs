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
    {
        if (transform.position.x > 6)
        {
            trail.emitting = false;
            transform.position = new Vector3(-6f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -6 || transform.position.x > -5)
        {
            trail.emitting = true;
        }

    }
}
