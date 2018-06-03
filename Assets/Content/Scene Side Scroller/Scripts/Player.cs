using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InjectBehaviour {

	public float force = 10;

	SceneManager sceneManager = null;

	public void Update() {

		var velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		GetComponent<Rigidbody2D>().AddForce(velocity * force * Time.deltaTime, ForceMode2D.Impulse);
	}
}
