using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ship : MonoBehaviour
{

	NavMeshAgent agent;
	WarLogic target;

	private void Awake() {
		agent = GetComponent<NavMeshAgent>();
	}
	public void GoTo(WarLogic planet) {
		target = planet;
		agent.SetDestination(planet.sphere.position);
	}

	private void OnTriggerEnter(Collider other) {
		if ( !target ) return;
		WarLogic planet = other.GetComponentInParent<WarLogic>();
		if ( !planet ) return;
		if (planet == target ) {
			planet.TakeAttack();
			Destroy(gameObject);
		}
	}
}
