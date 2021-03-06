﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[SelectionBase]
[RequireComponent(typeof(Rigidbody2D))]
public class SCR_Tower : MonoBehaviour {
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
			
			var create = GameObject.Instantiate(bullet.gameObject, this.CenterOfMass(), Quaternion.identity, transform.parent);
			create.gameObject.SetActive(true);
			if (findArea.overlap[0] != null) {
				Vector2 direction = findArea.overlap[0].CenterOfMass() - this.CenterOfMass();
				create.GetComponent<Rigidbody2D>().velocity = direction.normalized * shootSpeed;
			}
			
		}
	}
}
