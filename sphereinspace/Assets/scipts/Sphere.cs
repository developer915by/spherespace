﻿using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	public float spead, tilt;
	public Vector3 target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * spead);
        if  (transform.position == target && target.x != -3.5f)
            target.x = -3.5f;

      

       
       
        else if (transform.position == target && target.x == -3.5f)
			target.x = 3.5f;
        

        transform.Rotate (Vector3.one * Time.deltaTime * tilt);
	}
}
