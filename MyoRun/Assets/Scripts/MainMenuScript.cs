using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public string IP = "127.0.0.1";
	public int PORT = 8080;

	public void NewGame(string newGameLevel){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("LeverScene");
	}
	public void SpectateGame() {
		if (Network.peerType == NetworkPeerType.Disconnected && !(Network.peerType == NetworkPeerType.Server)) {
			Network.Connect (IP, PORT);
		}
	}
	public void ExitGame() {
		Application.Quit ();
	}
}