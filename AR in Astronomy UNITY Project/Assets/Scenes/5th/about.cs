using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class about : MonoBehaviour {

        public void facebook()
            {
                Application.OpenURL("https://www.facebook.com/IoT-Club-Computer-Department-JSCOE-103606718043589/");
            }

        public void linkedin()
            {
                Application.OpenURL("https://www.linkedin.com/in/iot-club-63b510191");
            }

        public void youtube()
            {
                Application.OpenURL("https://www.youtube.com/channel/UCVZi7BU26ZCMRVsdrALQfYg");
            }

        public void website()
            {
                Application.OpenURL("https://jscoeiotclub.in/");
            }

        public void Playstore()
            {
                Application.OpenURL("https://play.google.com/store/apps/dev?id=7062813189037368202&hl=en_IN");
            }
public void back()
        { 
SceneManager.LoadScene("Menu");
        }

      

          
        
}
