using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[SelectionBase]
[RequireComponent(typeof(Rigidbody2D))]
public class SCR_Tower : MonoBehaviour, IPointerClickHandler {
	[Header("Customizable")]
	public float shootRate = 0.5f;
	public float shootSpeed = 1f;

	[Header("References")]
	public SCR_Bullet bullet;
	public SCR_FindArea findArea;

	[Header("Fields")]
	public float lastShootTime;

	protected void Awake() {
		bullet.gameObject.SetActive(false);
	}

	public void FixedUpdate() {
		if (findArea.overlap.Count > 0 && 
			Time.time > lastShootTime + shootRate) {
			lastShootTime = Time.time;
			
			var create = GameObject.Instantiate(bullet.gameObject, this.centerOfMass(), Quaternion.identity, transform.parent);
			create.gameObject.SetActive(true);
			Vector2 direction = findArea.overlap[0].centerOfMass() - 
													this.centerOfMass();
			create.GetComponent<Rigidbody2D>().velocity = direction.normalized * shootSpeed;
			
		}
	}
	public void OnPointerClick(PointerEventData eventData) {
		print("click");
	}
}
