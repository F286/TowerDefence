using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomEventSystem : EventSystem {

	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) {
		print("raycast all");
	}
}
