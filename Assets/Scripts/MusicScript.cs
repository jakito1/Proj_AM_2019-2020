using System.Collections;
using UnityEngine;

public class MusicScript : MonoBehaviour
{

    void Start()
    {
	//Makes the music not overlap by itself if we're back to a menu the song was already playing.
        GameObject[] objects = GameObject.FindGameObjectsWithTag("BackgroundMusic");

	if(objects.Length > 1){
		Destroy(this.gameObject);
	}else
		//Allows the music to continue playing seamlessly when changing scenes.
		DontDestroyOnLoad(this.gameObject);
    }

    public void muteBackgroundMusic(){
	AudioListener.pause = true;
    }

    public void unmuteBackgroundMusic(){
	AudioListener.pause = false;
    }

}
