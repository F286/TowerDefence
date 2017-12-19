using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using DG.Tweening;

public class SCR_SpawnAndDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IInitializePotentialDragHandler {
	[Header("Customizable")]
	public Vector2 offset = new Vector2(-0.5f, -0.5f);

	[Header("References")]
	public GameObject template;

	[Header("Fields")]
	public GameObject dragging;

	public void OnBeginDrag(PointerEventData eventData) {
		Assert.IsNull(dragging, "Cannot drag multiple objects at the same time: <b>" + name + "</b>");

		// Copy the template
		dragging = GameObject.Instantiate(template, WorldPosition(eventData), Quaternion.identity, template.transform.parent);
		dragging.SetActive(true);
	}
	public void OnDrag(PointerEventData eventData) {
		dragging.transform.position = WorldPosition(eventData);
	}
	public void OnEndDrag(PointerEventData eventData) {
		// Snap
		dragging.transform.DOMove(WorldPosition(eventData).SnapToGrid(), 0.2f);
		
		dragging = null;
	}
	public void OnInitializePotentialDrag(PointerEventData eventData) {
		eventData.useDragThreshold = false;
	}

	Vector2 WorldPosition(PointerEventData eventData) {
		return eventData.ToWorld() + offset;
	}

	protected void Awake() {
		template.SetActive(false);
	}
}
