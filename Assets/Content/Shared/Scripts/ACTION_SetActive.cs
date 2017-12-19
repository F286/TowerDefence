using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ACTION_SetActive : MonoBehaviour, IAction {
	public GameObject target;
	public bool isActive = true;
	
	public void OnEvent() {
		target.SetActive(isActive);
	}
}
