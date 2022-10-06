using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseButtonScript : MonoBehaviour
{
     public GameObject PauseMenu; 
     public Button btn1;
     public Button btn2;
     public Button btn3;
     public Button btn4;
     public Button btn5;
     public Button btn6;

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }


    public void PauseButtonAction(){
	PauseMenu.SetActive(true);
	btn1.enabled = false;
	btn2.enabled = false;
	btn3.enabled = false;
	btn4.enabled = false;
	btn5.enabled = false;
	btn6.enabled = false;
	Time.timeScale = 0;

    }


    public void ResumeButtonAction(){
	PauseMenu.SetActive(false);
	btn1.enabled = true;
	btn2.enabled = true;
	btn3.enabled = true;
	btn4.enabled = true;
	btn5.enabled = true;
	btn6.enabled = true;
	Time.timeScale = 1;
    }


}
