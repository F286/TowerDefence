using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Bullet : MonoBehaviour {
	public float damage;

	protected void OnCollisionEnter2D(Collision2D other) {
		other.collider.attachedRigidbody.SendMessage("Damage", damage);
		Destroy(gameObject);
	}
}
