using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace HelloCube.EnableableComponents
{
    public class RotationSpeedAuthoring : MonoBehaviour
    {
        public bool StartEnabled;
        public float DegreesPerSecond = 360.0f;

        public class Baker : Baker<RotationSpeedAuthoring>
        {
            public override void Bake(RotationSpeedAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);

                AddComponent(entity, new EnableableRotationSpeed { RadiansPerSecond = math.radians(authoring.DegreesPerSecond) });
                SetComponentEnabled<EnableableRotationSpeed>(entity, authoring.StartEnabled);
            }
        }
    }

    public struct EnableableRotationSpeed : IComponentData, IEnableableComponent
    {
        public float RadiansPerSecond;
    }
}
