using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLauncher : MonoBehaviour
{
	public Transform planetBody;
	WarLogic warLogic;

	private void Awake() {
		warLogic = GetComponent<WarLogic>();
	}

	public void SetUp(int shipsCount) {
		planetBody.localScale = Vector3.one * Mathf.Sqrt((float)shipsCount / 40f);
		warLogic.SetUp(shipsCount);
	}
}
