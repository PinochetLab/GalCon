using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPosition : MonoBehaviour
{
	[SerializeField] Transform planet;

	private void Update() {
		transform.position = planet.position + Vector3.up * 10;
	}
}
