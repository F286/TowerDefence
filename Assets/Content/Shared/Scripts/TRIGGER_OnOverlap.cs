using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_OnOverlap : MonoBehaviour, ITrigger {
	
	public void OnTriggerEnter2D() {
		this.TriggerEvent();
	}
}
