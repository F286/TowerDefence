using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ACTION_DebugLog : MonoBehaviour, IAction {
	public string text = "ACTION_Debug Hit";
	
	public void OnEvent() {
		Debug.Log("<b><size=23>" + text + "</size></b>", this);
	}
}
