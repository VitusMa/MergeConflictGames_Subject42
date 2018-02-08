﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{

	public AudioClip Dialogue;
	bool alreadyTriggered;

	void Start ()
	{
		alreadyTriggered = false;
	}

	void OnTriggerEnter (Collider col)
	{
		if (!alreadyTriggered) {
			SoundManager.instance.PlayCombinedDialogue (Dialogue, 1f);
			alreadyTriggered = true;
		}
	}

}
