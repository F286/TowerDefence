using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_Delay : MonoBehaviour, ITrigger {
	public float delay = 2.5f;
	float startTime;
	bool isEnabled;

	protected void OnEnable() {
		startTime = Time.time;
		isEnabled = true;
	}

	public void Update() {
		if (isEnabled && Time.time > startTime + delay) {
			isEnabled = false;
			this.TriggerEvent();
		}
	}
}
