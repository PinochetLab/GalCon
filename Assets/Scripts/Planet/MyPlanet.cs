using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlanet : MonoBehaviour
{
	MeshRenderer meshRenderer;
	Selecter selecter;
	WarLogic warLogic;

	bool selected = false;


	private void Awake() {
		warLogic = GetComponent<WarLogic>();
		meshRenderer = GetComponentInChildren<MeshRenderer>();
		meshRenderer.material.color = Color.green;
		selecter = GetComponentInChildren<Selecter>();
		warLogic.shipsGenerator.enabled = true;
	}

	private void Start() {
	}

	private void Update() {
		LookForTap();
	}

	void LookForTap() {
		if ( selected ) {
			if ( Input.GetMouseButtonDown(0)){
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Physics.Raycast(ray, out RaycastHit hit);
				if ( !hit.collider ) {
					Deselect();
				}
				else {
					if (hit.collider.transform.root != transform.root ) {
						warLogic.Attack(hit.collider.GetComponentInParent<WarLogic>());
						Deselect();
					}
				}
			}
		}
	}

	public void TrySelect() {
		print("Yes");
		if ( !selected ) Select();
		else Deselect();
	}

	public void Select() {
		selected = true;
		selecter.Select();

		foreach (MyPlanet my in GameObject.FindObjectsOfType<MyPlanet>() ) {
			if ( my != this ) my.Deselect();
		}
	}

	public void Deselect() {
		selected = false;
		selecter.Deselect();
	}
}
