using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CoinsCounter : MonoBehaviour
{
	public Text text;
	public static int numberOfCoins = 500;

    // Start is called before the first frame update
    void Start()
    {

	text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {

	text.text = numberOfCoins.ToString();
		
    }
}
