using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SCR_Monster : MonoBehaviour, IDamageable {
	[Header("Customizable")]
	public int health = 100;

	[Header("Fields")]
	public bool isActive = true;

	protected void Update() {
		if (health == 0 && isActive) {
			isActive = false;
			GetComponent<SpriteRenderer>()
				.DOFade(0, 0.2f)
				.SetDelay(0.2f)
				.OnComplete(() => Destroy(gameObject));
		}
	}

	public void Damage(int amount) {
		health -= amount;
	}
}
