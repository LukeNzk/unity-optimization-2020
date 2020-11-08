using UnityEngine;
// ReSharper disable Unity.InefficientPropertyAccess
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable Unity.InefficientMultiplicationOrder

public class Pawn : MonoBehaviour
{
    private Vector3 _dir = Vector3.zero;
    private Vector3 _center;
    private Transform _transform;
    private float _speed = 0.2f;
    

    void Start()
    {
        _center = Random.insideUnitSphere;
        _transform = transform;
    }
    
    public void Move()
    {
        Vector3 toCenter = _center - _transform.position;
        toCenter *= Mathf.Exp(toCenter.magnitude) / 100.0f;
        
        Vector3 randomDir = Random.onUnitSphere + _dir * 20.0f + toCenter;
        randomDir.Normalize();
        _dir = randomDir;
        
        _transform.position += randomDir * _speed * Time.deltaTime;
    }
}
