using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour
{
    [SerializeField] private int _count = 0;
    [SerializeField] private GameObject _prefab;

    private List<Pawn> _pawns = new List<Pawn>();

    void Start()
    {
        Transform t = transform;
        for (int i = 0; i < _count; ++i)
        {
            var go = Object.Instantiate(_prefab, t.position, t.rotation, t);
            var pawn = new Pawn();
            _pawns.Add(pawn);
            pawn.Start(go);
        }
    }

    void Update()
    {
        float dt = Time.deltaTime;
        var count = _pawns.Count;
        for (int i = 0; i < _pawns.Count; ++i)
        {
            _pawns[i].Move(dt);
        }
    }
}
