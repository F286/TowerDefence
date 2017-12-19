using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_OnEnable : MonoBehaviour, ITrigger {
	
	public void OnEnable() {
		this.TriggerEvent();
	}
}
