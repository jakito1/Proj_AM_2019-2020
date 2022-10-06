using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningLocation : MonoBehaviour
{

	public GameObject coin;
	public Vector3 center;
	public Vector3 size;
	private float firstSpawn = 10;
	private float nextSpawn = 10;	

    // Start is called before the first frame update
    void Start()
    {
	InvokeRepeating("SpawnLocation", firstSpawn, nextSpawn);   
    }


	 void SpawnLocation(){
			Vector3 newPos = center + new Vector3(Random.Range(-size.x, size.x), 5f, Random.Range(-size.z, size.z));
			Instantiate(coin, newPos, Quaternion.identity);
	 }



}
