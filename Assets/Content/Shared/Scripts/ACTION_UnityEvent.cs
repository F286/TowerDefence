using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ACTION_UnityEvent : MonoBehaviour, IAction {
	public UnityEvent unityEvent;
	
	public void OnEvent() {
		unityEvent.Invoke();
	}
}
