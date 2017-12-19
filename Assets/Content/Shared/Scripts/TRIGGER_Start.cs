using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_Start : MonoBehaviour, ITrigger {
	
	public void Start() {
		this.TriggerEvent();
	}
}
