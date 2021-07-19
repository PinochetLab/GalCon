using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUpdate : MonoBehaviour
{
	WarLogic warLogic;
	TextMesh textMesh;

	private void Start() {
		warLogic = GetComponentInParent<WarLogic>();
		textMesh = GetComponent<TextMesh>();
	}

	private void Update() {
		textMesh.text = warLogic.shipsCount.ToString();
	}
}
