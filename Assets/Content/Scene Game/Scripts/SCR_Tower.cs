using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class SCR_Tower : MonoBehaviour {
	public SCR_Bullet bullet;
	public SCR_FindArea findArea;

	protected void Awake() {
		bullet.gameObject.SetActive(false);
	}

}
