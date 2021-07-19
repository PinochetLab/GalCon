using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawner : MonoBehaviour
{
	[SerializeField] StartOptions startOptions;
	[SerializeField] GameObject planetPrefab;
	List<GameObject> planets = new List<GameObject>();

	private void Start() {
		int planetsCount = startOptions.planetsCount;
		int minShipsCount = startOptions.minShipsCount;
		int maxShipsCount = startOptions.maxShipsCount;

		for (int i = 0; i < planetsCount; i++ ) {
			Vector3 position = new Vector3(Random.Range(-4f, 4f), 0, Random.Range(-4f, 4f));
			GameObject planet = Instantiate(planetPrefab, position, Quaternion.identity);
			planets.Add(planet);
			planet.GetComponent<PlanetLauncher>().SetUp(Random.Range(minShipsCount, maxShipsCount));
		}

		planets[Random.Range(0, planets.Count)].AddComponent<MyPlanet>();
	}
}
