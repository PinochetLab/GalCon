using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecter : MonoBehaviour
{
	[SerializeField] GameObject selection;

	private void OnMouseDown() {
		MyPlanet myPlanet = GetComponentInParent<MyPlanet>();
		if ( !myPlanet ) return;
		myPlanet.TrySelect();
	}

	public void Select() {
		selection.SetActive(true);
	}

	public void Deselect() {
		selection.SetActive(false);
	}
}
