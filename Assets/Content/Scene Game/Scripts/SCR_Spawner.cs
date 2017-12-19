using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[RequireComponent(typeof(Rigidbody2D))]
public class SCR_Spawner : MonoBehaviour {
	[Header("Customizable")]
	public float rate = 0.5f;

	[Header("References")]
	public GameObject template;
	public Transform spawnAt;

	[Header("Fields")]
	public float lastSpawnTime = -100;

	protected void Awake() {
		template.gameObject.SetActive(false);
	}

	public void FixedUpdate() {
		if (Time.time > lastSpawnTime + rate) {
			lastSpawnTime = Time.time;
			
			// Copy the template
			var create = GameObject.Instantiate(template, spawnAt.position, Quaternion.identity, transform.parent);
			create.gameObject.SetActive(true);
		}
	}

}
