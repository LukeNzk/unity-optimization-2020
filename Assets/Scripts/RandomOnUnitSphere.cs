using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOnUnitSphere
{
    private static Vector3[] _vectors;
    private static int _currentIndex = 0;

    public static void Generate(int n)
    {
        _vectors = new Vector3[n];
        for (int i = 0; i < n; ++i)
        {
            _vectors[i] = Random.onUnitSphere;
        }
    }

    public static Vector3 Next()
    {
        if (++_currentIndex == _vectors.Length)
        {
            _currentIndex = 0;
        }
        
        return _vectors[_currentIndex];
    }
}
