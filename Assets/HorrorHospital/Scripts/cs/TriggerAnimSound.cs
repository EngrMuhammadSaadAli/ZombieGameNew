using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(Collider))]


public class TriggerAnimSound : MonoBehaviour
{
	public AudioClip m_Sound;
	
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.name == "_FPSPlayer")
		{
			GetComponent<Collider>().enabled = false;	// do it once
			GetComponent<Animation>().Play();
	
			if (m_Sound != null)
				AudioSource.PlayClipAtPoint(m_Sound, transform.position);
			else
				Debug.LogError("TriggerAnimSound: Sound not specified for - " + this.name);
		}
	}
}
