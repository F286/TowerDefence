using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGER_GlobalEvent : MonoBehaviour, ITrigger {
	[Header("Name of the global event")]
	public string eventName;

	public void OnEvent() {
		this.TriggerEvent();
	}
}