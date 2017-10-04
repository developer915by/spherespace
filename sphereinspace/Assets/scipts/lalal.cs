using UnityEngine;
using System.Collections;
using CnControls;
using UnityEngine.UI;

public class lalal : MonoBehaviour {
	public Text PointText;
	private int PointInt = 0;
	public float titl;
	Vector3 position;
	void Start () {

	}

	void FixedUpdate () {
		position = new Vector3(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"), 0f);

		transform.position += position*Time.deltaTime*5;
		transform.Rotate (Vector3.one * Time.deltaTime * titl);

		PointText.text = PointInt.ToString ();
	}

	void OnTriggerEnter(Collider collider)
	{
		PointInt++;
		Destroy (collider.gameObject);
	}
}
