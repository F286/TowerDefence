using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : InjectBehaviour {
	public bool isOn;
	SceneManager sceneManager = null;
	SideScroller sideScroller = null;

	public override void Awake() {
		base.Awake();
		// print(sceneManager);
		// print(sideScroller);
	}

}
