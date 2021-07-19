using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarLogic : MonoBehaviour
{
	[System.NonSerialized] public int shipsCount = 0;
	[System.NonSerialized] public int maxShipsCount = 0;

	[SerializeField] GameObject shipPrefab;
	public Transform sphere;
	public ShipsGenerator shipsGenerator;

	private void Awake() {
		shipsGenerator.enabled = false;
	}


	public void SetUp(int _shipsCount) {
		shipsCount = _shipsCount;
		maxShipsCount = _shipsCount;
	}

    public void TakeAttack() {
		if ( GetComponent<MyPlanet>() ) return;
		shipsCount--;
		if (shipsCount < 1 ) {
			transform.root.gameObject.AddComponent<MyPlanet>();
		}
	}

	public void Attack(WarLogic other) {
		if ( other.GetComponent<MyPlanet>() ) return;
		int count = shipsCount / 2;

		shipsCount -= count;

		for (int i = 0; i < count; i++ ) {
			Ship ship = Instantiate(shipPrefab, sphere.position, Quaternion.identity).GetComponent<Ship>();
			ship.GoTo(other);
		}
	}
}
