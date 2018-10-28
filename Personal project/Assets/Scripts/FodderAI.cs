using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FodderAI : MonoBehaviour {

    public float speed = 1.0f;
    public float sinAmplitude = 1.0f;
    public float sinFrequency = 1.0f;
    public float time;
    private float horizontalOffset = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        //remove offset from enemy
        transform.position -= horizontalOffset * transform.right;

        //moves enemy forward
        transform.position += transform.forward * speed * Time.deltaTime;

        //moves left and right one a sine wave pattern
        horizontalOffset = Mathf.Sin(time * sinFrequency * 2 * Mathf.PI) * sinAmplitude;
        Vector3 newPosition = transform.position;
        transform.position += horizontalOffset * transform.right;
    }
}
