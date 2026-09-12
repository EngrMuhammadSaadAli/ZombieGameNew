using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Collider))]


public class TriggerSound : MonoBehaviour
{
	public AudioClip m_Sound;
	

	public void OnTriggerEnter(Collider other)
	{ 
		if (other.name == "_FPSPlayer")
		{
			GetComponent<Collider>().enabled = false;		// only do it once
	
			if (m_Sound != null)
				AudioSource.PlayClipAtPoint(m_Sound, transform.position);
		}
	}
}
