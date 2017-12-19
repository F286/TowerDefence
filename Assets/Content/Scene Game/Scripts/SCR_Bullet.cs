using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Bullet : MonoBehaviour {
	[Header("Customizable")]
	public int damage = 25;

	[Header("Fields")]
	public bool isActive = true;

	protected void Start() {
		Destroy(gameObject, 5);
	}

	protected void OnCollisionEnter2D(Collision2D other) {
		if (isActive) {
			isActive = false;
			other.collider.attachedRigidbody.SendMessage("Damage", damage);
			Destroy(gameObject, 1f);
		}
	}
}
