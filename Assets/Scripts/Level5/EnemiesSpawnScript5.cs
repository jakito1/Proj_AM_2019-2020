using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawnScript5 : MonoBehaviour
{
	private Vector3 center;
	private Vector3 size;
	public GameObject golemTear1;
	public GameObject golemTear2;
	public GameObject golemTear3;
	public GameObject kratus;
	public GameObject titanKing;
	private float firstSpawn = 1;
	private float nextSpawn = 5;

	void Start(){
		 StartCoroutine(SpawnEnemies());
	}


	 void GolemTear1Spawn(){
			Vector3 newPos = center + new Vector3(-171.8f, 0.76f, -5758.11f);
			Instantiate(golemTear1, newPos, Quaternion.identity);
	 }
	 
	void GolemTear2Spawn(){
			Vector3 newPos = center + new Vector3(-171.8f, 0.76f, -5758.11f);
			Instantiate(golemTear2, newPos, Quaternion.identity);
	 }

	void GolemTear3Spawn(){
			Vector3 newPos = center + new Vector3(-171.8f, 0.76f, -5758.11f);
			Instantiate(golemTear3, newPos, Quaternion.identity);
	 }

	void KratusSpawn(){
			Vector3 newPos = center + new Vector3(-171.8f, 0.76f, -5758.11f);
			Instantiate(kratus, newPos, Quaternion.identity);
	 }

	void TitanKingSpawn(){
			Vector3 newPos = center + new Vector3(-171.8f, 0.76f, -5758.11f);
			Instantiate(titanKing, newPos, Quaternion.identity);
	 }


	IEnumerator SpawnEnemies(){
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(15);
		GolemTear1Spawn();
		yield return new WaitForSeconds(15);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
		yield return new WaitForSeconds(5);
		KratusSpawn();
	}
}
