using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_FindArea : MonoBehaviour {
	public List<Collider2D> overlap;

	protected void OnTriggerEnter2D(Collider2D other) {
		overlap.Add(other);
	}
	protected void OnTriggerExit2D(Collider2D other) {
		overlap.Remove(other);
	}
}
