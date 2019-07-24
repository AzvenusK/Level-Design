using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour 
{
	bool canFlicker = true;
	private Light myLight;
	public AudioClip audioClip;
	void Update()
	{
		StartCoroutine (Flicker ());
	}

	IEnumerator Flicker()
	{
		if (canFlicker) {
			canFlicker = false;
			GetComponent<AudioSource>().PlayOneShot (audioClip);
			myLight = GetComponent<Light> ();
			myLight.enabled = true;
			yield return new WaitForSeconds (Random.Range (0.1f, 0.4f));
			myLight.enabled = false;
			yield return new WaitForSeconds (Random.Range (1, 5));
			canFlicker = true;
		}
	}
}
