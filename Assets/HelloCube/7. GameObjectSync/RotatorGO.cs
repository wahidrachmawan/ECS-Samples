using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace HelloCube.GameObjectSync {

	public class RotatorGO : IComponentData {
		public GameObject Value;

		public RotatorGO(GameObject value) {
			Value = value;
		}

		// Every IComponentData class must have a no-arg constructor.
		public RotatorGO() {
		}
	}
}