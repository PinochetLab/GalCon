using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StartOptions", menuName = "ScriptableObjects/StartOptions", order = 1)]
public class StartOptions : ScriptableObject
{
	public int planetsCount = 10;

	public int minShipsCount = 5;
	public int maxShipsCount = 45;
}
