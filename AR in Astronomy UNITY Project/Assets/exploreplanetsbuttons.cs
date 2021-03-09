using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class exploreplanetsbuttons : MonoBehaviour {



	public void sun()
        { 
SceneManager.LoadScene("Sun");
        }

public void mercury()
        { 
SceneManager.LoadScene("Mercury");
        }

public void venus()
        { 
SceneManager.LoadScene("Venus");
        }

public void earth()
        { 
SceneManager.LoadScene("Earth");
        }

public void mars()
        { 
SceneManager.LoadScene("Mars");
        }

public void jupiter()
        { 
SceneManager.LoadScene("Jupiter");
        }

public void saturn()
        { 
SceneManager.LoadScene("Saturn");
        }

public void uranus()
        { 
SceneManager.LoadScene("Uranus");
        }

public void neptune()
        { 
SceneManager.LoadScene("Neptune");
        }


public void back()
        { 
SceneManager.LoadScene("planets_Menu");
        }

public void back2Menu()
        { 
SceneManager.LoadScene("Menu");
        }


}
