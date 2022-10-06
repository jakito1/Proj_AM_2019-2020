using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurryHealthScript : MonoBehaviour
{
	private float startHealth = 50f;
	private float currentHealth;
	public Image healthBar;
	public GameObject hero;





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
			Destroy(hero);
			
		}
	}




	IEnumerator dealDamageKratus(){
		while(currentHealth > 0){	
			TakeDamage(5);
			yield return new WaitForSeconds(2);}
	}

	IEnumerator dealDamageGolem(){
		while(currentHealth > 0){	
			TakeDamage(25);
			yield return new WaitForSeconds(5);}
	}


	IEnumerator dealDamageTitan(){
		while(currentHealth > 0){	
			TakeDamage(15);
			yield return new WaitForSeconds(5);}
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Kratus"){
			StartCoroutine(dealDamageKratus());
		}else{
			StopCoroutine(dealDamageKratus());
		     }
		
		if(other.gameObject.tag == "Golem"){
			StartCoroutine(dealDamageGolem());
		}else{
			StopCoroutine(dealDamageGolem());
		     }


		if(other.gameObject.tag == "Titan"){
			StartCoroutine(dealDamageTitan());
		}else{
			StopCoroutine(dealDamageTitan());
		     }
	}
	





}
