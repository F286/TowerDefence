using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_OnCollide : MonoBehaviour, ITrigger {
	
	public void OnCollisionEnter2D() {
		this.TriggerEvent();
	}
}
