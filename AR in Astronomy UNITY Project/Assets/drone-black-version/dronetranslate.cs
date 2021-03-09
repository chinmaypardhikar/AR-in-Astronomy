using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dronetranslate : MonoBehaviour {

        Vector3 st;
        Vector3 ed;
        public float fraction_of_way_there;
        

	// Use this for initialization
	void Start () {
		st = transform.position;
                ed = transform.position + new Vector3 (0,4,0);
	}
	
	// Update is called once per frame
	void Update () {
                
                  fraction_of_way_there += 0.005f;
                  transform.position = Vector3.Lerp (st,ed,fraction_of_way_there);
                
	}
}
