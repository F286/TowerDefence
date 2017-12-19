using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class SCR_SpriteManager : MonoBehaviour {

	SCR_SpriteManager() {
		EditorApplication.hierarchyWindowChanged -= MyHierarchyChangedCallback;
		EditorApplication.hierarchyWindowChanged += MyHierarchyChangedCallback;
	}

	private static void MyHierarchyChangedCallback() {
		var sprites = GameObject.FindObjectOfType<SCR_SpriteManager>()
									.GetComponentsInChildren<SpriteRenderer>();
		var index = 0;
		foreach (var item in sprites) {
			index += 1;
			item.sortingOrder = index;
		}
	}

	// protected void Update () {
	// 	if (Application.isEditor) {
	// 		var sprites = GetComponentsInChildren<SpriteRenderer>();
	// 		var index = 0;
	// 		foreach (var item in sprites) {
	// 			index += 1;
	// 			item.sortingOrder = index;
	// 		}
	// 	}
	// }

}
