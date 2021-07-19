using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsGenerator : MonoBehaviour
{
	WarLogic warLogic;

	[SerializeField] int rate = 5;

	float time = 0;

	private void Awake() {
		warLogic = GetComponent<WarLogic>();
	}

	private void Update() {
		time += Time.deltaTime;
		int count = warLogic.shipsCount;
		if (time > 1f / (float)rate ) {
			time = 0;
			count++;
			warLogic.shipsCount = Mathf.Min(count, warLogic.maxShipsCount);
		}
	}
}
