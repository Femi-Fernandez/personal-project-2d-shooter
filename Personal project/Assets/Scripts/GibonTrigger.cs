using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibonTrigger : MonoBehaviour {


    public GameObject gib = null;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter ()
    {
        if (gib != null)
        {
            Instantiate(gib, transform.position, gib.transform.rotation);
        }
        Destroy(gameObject);
    }
}
