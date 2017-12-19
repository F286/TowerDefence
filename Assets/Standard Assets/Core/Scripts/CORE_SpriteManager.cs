using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class CORE_SpriteManager : MonoBehaviour {

	CORE_SpriteManager() {
		EditorApplication.hierarchyWindowChanged -= MyHierarchyChangedCallback;
		EditorApplication.hierarchyWindowChanged += MyHierarchyChangedCallback;
	}
	
	static void MyHierarchyChangedCallback() {
		var sprites = GameObject.FindObjectOfType<CORE_SpriteManager>()
									.GetComponentsInChildren<SpriteRenderer>();
		var index = 0;
		foreach (var item in sprites) {
			index += 1;
			item.sortingOrder = index;
		}
	}

}
