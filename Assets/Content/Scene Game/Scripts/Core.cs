using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Core {
	public static Vector2 centerOfMass(this Component transform) {
		return transform.GetComponent<Rigidbody2D>().worldCenterOfMass;
	}
}
