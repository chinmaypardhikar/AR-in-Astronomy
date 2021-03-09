using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour {

       string btnName;
       public GameObject neilindicator, kalindicator;

	// Use this for initialization
	void Start () {
		
                kalindicator.SetActive(false);
                neilindicator.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
		
           if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                   Ray ray= Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                  RaycastHit Hit;

                   if(Physics.Raycast(ray, out Hit))
                    {
                        btnName = Hit.transform.name;
                         switch(btnName)
                         {
                          case "Cube":
                           kalindicator.SetActive(true);
                           neilindicator.SetActive(false);
                           SceneManager.LoadScene("kalpana");
                
                            break;

                          case "Cube2":
                           kalindicator.SetActive(false);
                           neilindicator.SetActive(true);
                           SceneManager.LoadScene("Neil");
                        
                            break;

                          default:
                             break;
                           
                         }
                     }
            }
	}
}