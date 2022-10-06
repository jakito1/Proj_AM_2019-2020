using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesLevel1Script : MonoBehaviour
{
    public float speed;
    private Vector3 move;
    private CharacterController cc;

	
 	void Start(){
		cc = GetComponent<CharacterController>();
	}
	
	private void Update () {

		move = new Vector3(0f,0f, speed);
		move = transform.TransformDirection(move);
			if(speed != 0){
				cc.Move(move*Time.deltaTime);
				GetComponent<Animator>().SetTrigger("TriggerWalk");
			}
	}
		

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "moveDiag"){
			cc.transform.Rotate(0,60,0);
			cc.Move(move*Time.deltaTime);

		}


		if(other.gameObject.tag == "moveL"){
			cc.transform.Rotate(0, 90,0);
			cc.Move(move*Time.deltaTime);

		}

		if(other.gameObject.tag == "moveDown"){
			cc.transform.Rotate(0,-90,0);

			cc.Move(move*Time.deltaTime);

		}



		if(other.gameObject.tag == "moveR"){
			cc.transform.Rotate(0,-80,0);
			cc.Move(move*Time.deltaTime);

		}


		
		if(other.gameObject.tag == "Kratus" || other.gameObject.tag == "Golem#1" || other.gameObject.tag == "Golem#2" || other.gameObject.tag == "Golem#3" || other.gameObject.tag == "Titan"){
			speed = 0;
			GetComponent<Animator>().SetTrigger("TriggerAttack");
		}else{
			if(gameObject.tag == "FurrySD"){speed = 4;
			}else if(gameObject.tag == "FurryHD"){speed = 4;
			}else if(gameObject.tag == "Nibber#1"){speed = 3;
			}else if(gameObject.tag == "Nibber#2"){speed = 3;
			}else if(gameObject.tag == "Nibber#3"){speed = 3;
			}else if(gameObject.tag == "WhiteKnight"){speed = 2;}
		     }




	}


}
