using Godot;

public class Orbit : MeshInstance
{
    public override void _Process(float delta)
    {
        var localTranslation = GlobalTranslation;
        var distance = localTranslation.DistanceTo(GetParentSpatial().GlobalTranslation);
        RotateAroundParent(Vector3.Up, delta * 1.8f / distance);
    }

    void RotateAroundParent(Vector3 axis, float angle)
    {
         //var rotatedPosition = Transform.basis.Rotated(axis, angle);
         var rotatedOrigin = Transform.origin.Rotated(axis, angle);
        
         Transform = new Transform(Transform.basis, rotatedOrigin);
    }
}
