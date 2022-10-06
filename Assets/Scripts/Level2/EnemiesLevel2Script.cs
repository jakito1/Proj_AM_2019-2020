using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiesLevel2Script : MonoBehaviour
{
    public float speed;
    private Vector3 move;
    private CharacterController cc;
    private float gravity = 20f;

 	void Start(){
		cc = GetComponent<CharacterController>();
		GetComponent<Animator>().SetTrigger("TriggerWalk");
	}
	
	void Update () {


		move = new Vector3(0f,0f, speed);
		move = transform.TransformDirection(move);
		move.y -= gravity*Time.deltaTime;		
		if(speed != 0){
			GetComponent<Animator>().SetTrigger("TriggerWalk");
			cc.Move(move*Time.deltaTime);}
			
	}
		
		

	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "moveR"){
			cc.transform.Rotate(0,90,0);
			cc.Move(move*Time.deltaTime);

		}


		if(other.gameObject.tag == "moveDown"){
			cc.transform.Rotate(0,90,0);
			cc.Move(move*Time.deltaTime);

		}


		if(other.gameObject.tag == "moveDiag"){
			cc.transform.Rotate(0,-60,0);
			cc.Move(move*Time.deltaTime);

		}


		if(other.gameObject.tag == "moveL"){
			cc.transform.Rotate(0,-90,0);
			cc.Move(move*Time.deltaTime);

		}

		if(other.gameObject.tag == "FurrySD" || other.gameObject.tag == "FurryHD" ||other.gameObject.tag == "SirNibber#1" ||other.gameObject.tag == "SirNibber#2" ||other.gameObject.tag == "SirNibber#3" ||other.gameObject.tag == "WhiteKnight"){ 
			speed = 0;
			GetComponent<Animator>().SetTrigger("TriggerAttack");
		}else{
			if(gameObject.tag == "Golem"){speed = 2;}
		     }


	}






		











}