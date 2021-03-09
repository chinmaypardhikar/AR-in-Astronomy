using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonevent : MonoBehaviour {

	public void button()
        { 
SceneManager.LoadScene("Solars");
        }
public void button2()
        { 
SceneManager.LoadScene("planets_Menu");
        }

public void button1()
        { 
SceneManager.LoadScene("Spacewalk");
        }

public void button3()
        { 
SceneManager.LoadScene("Spacecraft_Menu");
        }

public void back()
        { 
SceneManager.LoadScene("Menu");
        }

public void about()
        { 
SceneManager.LoadScene("About");
        }

public void Quit()
        { 
Application.Quit();
        }


public void HOF()
        { 
SceneManager.LoadScene("Astronauthalloffame");
        }

public void library()
        { 
SceneManager.LoadScene("Library");
        }


}
