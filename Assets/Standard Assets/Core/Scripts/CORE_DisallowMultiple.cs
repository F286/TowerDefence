using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CORE_DisallowMultiple : MonoBehaviour {
	protected void Awake() {
		Assert.IsTrue(tag != "Untagged", "Set <i>tag</i> when using SCR_DisallowMultiple: <b>" + name + "</b>");
		
		if (GameObject.FindGameObjectsWithTag(tag).Length > 1) {
			gameObject.SetActive(false);
		}
	}
}
