using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

namespace HelloCube.GameObjectSync
{
    // The "Directory" acts as a central place to reference GameObject prefabs and managed objects.
    // Systems can then get references to managed objects all from one place.
    // (In a large project, you may want more than one "directory" if dumping
    // all the managed objects in one place gets too unwieldy.)

    public class Directory : MonoBehaviour
    {
        public GameObject RotatorPrefab;
        public Toggle RotationToggle;
	}

	public class DirectoryManaged : IComponentData {
		public GameObject RotatorPrefab;
		public Toggle RotationToggle;

		// Every IComponentData class must have a no-arg constructor.
		public DirectoryManaged() { }
	}
}
