using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ACTION_GlobalEvent : MonoBehaviour, IAction {
	[Header("Name of the global event")]
	public string eventName;
	
	public void OnEvent() {
		Core.SendGlobalEvent(eventName, this);
	}
}
