using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour
{
    [SerializeField] private int _count = 0;
    [SerializeField] private GameObject _prefab;

    void Start()
    {
        Transform t = transform;
        for (int i = 0; i < _count; ++i)
        {
            Object.Instantiate(_prefab, t.position, t.rotation, t);
        }
    }
}
