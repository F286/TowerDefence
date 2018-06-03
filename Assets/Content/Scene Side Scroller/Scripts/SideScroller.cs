using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : InjectBehaviour {
	public Vector2 gravity;

	public override void Awake() {
		base.Awake();
		Physics2D.gravity = gravity;
	}

}
