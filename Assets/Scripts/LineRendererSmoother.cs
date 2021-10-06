using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererSmoother : MonoBehaviour
{
    public LineRenderer Line;
    public Vector3[] InitialState;
    public float SmoothingLength = 2f;
    public int SmoothingSections = 10;
}
