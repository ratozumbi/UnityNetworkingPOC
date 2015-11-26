using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour {

	public Camera fpsCamera;
	public AudioListener fpsAudioListner;
	// Use this for initialization
	void Start () {

		if (!isLocalPlayer) {
			return;
		}
		GameObject.Find ("Main Camera").SetActive(false);
		GetComponent<CharacterController> ().enabled = true;
		GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
		GetComponent<AudioSource> ().enabled = true;

		fpsCamera.enabled = true;
		fpsAudioListner.enabled = true;
	}
}
