using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Monster : MonoBehaviour, IDamageable {
	public int health = 100;

	protected void Update() {
		if (health == 0) {
			Destroy(gameObject);
		}
	}

	public void Damage(int amount) {
		health -= amount;
	}
}
