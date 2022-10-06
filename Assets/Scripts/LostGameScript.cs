using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LostGameScript : MonoBehaviour
{

    public GameObject LostMenu; 
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btnPause;


    void Start()
    {
		LostMenu.SetActive(false);
    }

	void OnTriggerEnter(Collider other){
			
		if(other.gameObject.tag == "Kratus"){
			LostMenu.SetActive(true);
			btn1.enabled = false;
			btn2.enabled = false;
			btn3.enabled = false;
			btn4.enabled = false;
			btn5.enabled = false;
			btn6.enabled = false;
			btnPause.enabled = false;
			Time.timeScale = 0;
			
		}

		if(other.gameObject.tag == "Golem"){
			LostMenu.SetActive(true);
			btn1.enabled = false;
			btn2.enabled = false;
			btn3.enabled = false;
			btn4.enabled = false;
			btn5.enabled = false;
			btn6.enabled = false;
			btnPause.enabled = false;
			Time.timeScale = 0;
			
		}

		if(other.gameObject.tag == "Titan"){
			LostMenu.SetActive(true);
			btn1.enabled = false;
			btn2.enabled = false;
			btn3.enabled = false;
			btn4.enabled = false;
			btn5.enabled = false;
			btn6.enabled = false;
			btnPause.enabled = false;
			Time.timeScale = 0;
			
		}

	}



}
