using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class MenuManager : MonoBehaviour {


	public Text muteButtonText;
	AudioSource backgroundMusic;


	void Start(){

		backgroundMusic = GetComponent<AudioSource> ();

	}

	public void SceneToChange(string SceneToChangeTo){


		SceneManager.LoadScene (SceneToChangeTo);


	}
		

	public void QuitGame(){

		Application.Quit ();

	}


	//Sound 
	public void SoundMute(){

		if (backgroundMusic.isPlaying == true) {

			backgroundMusic.Pause ();
			muteButtonText.text = "Off";

		} else if (backgroundMusic.isPlaying == false) {


			backgroundMusic.Play ();
			muteButtonText.text = "On";

		
		}
	}
}
