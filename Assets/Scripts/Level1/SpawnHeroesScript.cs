using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnHeroesScript : MonoBehaviour
{

	private Vector3 center;
	private Vector3 size;
	public GameObject character;
	public Image image;


    void Start(){
		image.enabled = false;
	}

	public void SpawnFurries(){
			if(CoinsCounter.numberOfCoins >= 50){CoinsCounter.numberOfCoins -= 50;   
			Vector3 newPos = center + new Vector3(-136.26f, 0.7325805f, -5738.63f);
			Instantiate(character, newPos, Quaternion.identity);
			StartCoroutine(FurrySpawnTimer());}
	}

	public void SpawnNibbers(){
			if(CoinsCounter.numberOfCoins >= 120){CoinsCounter.numberOfCoins -= 120;  
			Vector3 newPos = center + new Vector3(-136.26f, 0.7614963f, -5739.83f);
			Instantiate(character, newPos, Quaternion.identity);
			StartCoroutine(NibberSpawnTimer());}
	}

	public void SpawnWhiteKnight(){
			if(CoinsCounter.numberOfCoins >= 300){CoinsCounter.numberOfCoins -= 300;  
			Vector3 newPos = center + new Vector3(-136.26f, 0.8687785f, -5739.83f);
			Instantiate(character, newPos, Quaternion.identity);
			StartCoroutine(WhiteKnightSpawnTimer());}
	}



	IEnumerator FurrySpawnTimer(){
		image.enabled = true;
		yield return new WaitForSeconds(3);	
		image.enabled = false;
	}

	IEnumerator NibberSpawnTimer(){
		image.enabled = true;
		yield return new WaitForSeconds(6);	
		image.enabled = false;
	}

	IEnumerator WhiteKnightSpawnTimer(){
		image.enabled = true;
		yield return new WaitForSeconds(10);	
		image.enabled = false;
	}





}
