using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using DG.Tweening;

public class SCR_DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IInitializePotentialDragHandler {
	[Header("Customizable")]
	public float animateDuration = 0.2f;
	public Vector2 offset = new Vector2(-0.5f, -0.5f);
	
	[Header("Fields")]
	public float dragTime;

	public void OnBeginDrag(PointerEventData eventData) {
		dragTime = 0f;
		AnimateToFinger(eventData);
	}
	public void OnDrag(PointerEventData eventData) {
		AnimateToFinger(eventData);
	}
	public void OnEndDrag(PointerEventData eventData) {
		// Snap
		transform.DOMove(WorldPosition(eventData).SnapToGrid(), animateDuration);
	}
	public void OnInitializePotentialDrag(PointerEventData eventData) {
		eventData.useDragThreshold = false;
	}

    void AnimateToFinger(PointerEventData eventData) {
		transform.position = Vector2.Lerp(transform.position, eventData.ToWorld() + offset, dragTime);

		dragTime += Time.deltaTime / animateDuration;
	}

	Vector2 WorldPosition(PointerEventData eventData) {
		return eventData.ToWorld() + offset;
	}
}
