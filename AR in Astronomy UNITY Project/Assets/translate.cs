using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour {

	
     
	
	public float Speed = 0.1f;
    void Update()
    {
        transform.Translate(0,0,1* Speed * Time.deltaTime);
    }
}
