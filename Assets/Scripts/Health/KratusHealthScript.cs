using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KratusHealthScript : MonoBehaviour
{
	private float startHealth = 50f;
	private float currentHealth;
	public Image healthBar;
	public GameObject enemy;




    void Start()
    {
        currentHealth = startHealth;
    }
    



	public void TakeDamage (float amount)
	{
		currentHealth -= amount;

		healthBar.fillAmount = currentHealth / startHealth;

		if (currentHealth <= 0)
		{
			//HeroesLevel1Script.canMove = true;
			Destroy(enemy);
		}
	}




	IEnumerator dealDamageFurrySD(){
		while(currentHealth > 0){	
			TakeDamage(5);
			yield return new WaitForSeconds(2);}
	}

	IEnumerator dealDamageFurryHD(){
		while(currentHealth > 0){	
			TakeDamage(7.5f);
			yield return new WaitForSeconds(5);}
	}

	IEnumerator dealDamageNibber1(){
		while(currentHealth > 0){	
			TakeDamage(10f);
			yield return new WaitForSeconds(5);}
	}

	IEnumerator dealDamageNibber2(){
		while(currentHealth > 0){	
			TakeDamage(12.5f);
			yield return new WaitForSeconds(5);}
	}

	IEnumerator dealDamageNibber3(){
		while(currentHealth > 0){	
			TakeDamage(15);
			yield return new WaitForSeconds(5);}
	}

	IEnumerator dealDamageWhiteKnight(){
		while(currentHealth > 0){	
			TakeDamage(25);
			yield return new WaitForSeconds(5);}
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "FurrySD"){
			StartCoroutine(dealDamageFurrySD());
		}else{
			StopCoroutine(dealDamageFurrySD());
		     }
		
		if(other.gameObject.tag == "FurryHD"){
			StartCoroutine(dealDamageFurryHD());
		}else{
			StopCoroutine(dealDamageFurryHD());
		     }

		if(other.gameObject.tag == "SirNibber#1"){
			StartCoroutine(dealDamageNibber1());
		}else{
			StopCoroutine(dealDamageNibber1());
		     }

		if(other.gameObject.tag == "SirNibber#2"){
			StartCoroutine(dealDamageNibber2());
		}else{
			StopCoroutine(dealDamageNibber2());
		     }

		if(other.gameObject.name == "SirNibber#3"){
			StartCoroutine(dealDamageNibber3());
		}else{
			StopCoroutine(dealDamageNibber3());
		     }

		if(other.gameObject.tag == "WhiteKnight"){
			StartCoroutine(dealDamageWhiteKnight());
		}else{
			StopCoroutine(dealDamageWhiteKnight());
		     }
	}






}