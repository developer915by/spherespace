using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Buttons : MonoBehaviour {
	
	public Sprite layer_blue, layer_red;

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "Play":
			SceneManager.LoadScene ("play");
			break;
		case "Rating":
			Application.OpenURL ("http://google.com");
			break;
		}
	}
}
