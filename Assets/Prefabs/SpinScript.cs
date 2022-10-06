using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SpinScript : MonoBehaviour
{

    void Update()
    {
	transform.Rotate(5, 0, 0);

    }

	void OnMouseDown(){
		CoinsCounter.numberOfCoins += 20;
		Destroy(gameObject);
	}
}
