using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GameManager : NetworkBehaviour {

	// Use this for initialization
	public void StartGame () {
		NetworkManager.singleton.StartHost ();
	}
	
	// Update is called once per frame
	public void JoinGame () {
		NetworkManager.singleton.StartClient ();
	}
}
