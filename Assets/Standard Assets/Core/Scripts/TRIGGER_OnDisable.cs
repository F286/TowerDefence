using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_OnDisable : MonoBehaviour, ITrigger {
	
	public void OnDisable() {
		this.TriggerEvent();
	}
}
