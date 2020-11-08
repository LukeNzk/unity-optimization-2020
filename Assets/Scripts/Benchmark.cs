using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Benchmark : MonoBehaviour
{
    private Text t;
    private float nextUpdateTime = 0;
    
    private float[] _frameTimes = new float[200];

    private int _measurementIndex = 0;
    [SerializeField] private string _fileName;
    
    void Start()
    {
        t = GetComponent<Text>();
        File.CreateText(_fileName).Dispose();
        RandomOnUnitSphere.Generate(1000);
    }

    void Update()
    {
        if (Time.time >= nextUpdateTime)
        {
            t.text = (1000.0f * Time.smoothDeltaTime).ToString();
            nextUpdateTime = Time.time + 1.0f;
        }

        _frameTimes[_measurementIndex] = Time.deltaTime;
        _measurementIndex++;
        if (_measurementIndex == _frameTimes.Length - 1)
        {
            Save();
        }
    }

    void Save()
    {
        _measurementIndex = 0;
        string str = "";
        foreach (float time in _frameTimes)
        {
            if (time == 0.0f) continue;
            str += (1000.0f * time).ToString() + '\n';
        }
        var writer = File.AppendText(_fileName);
        writer.Write(str);
        writer.Dispose();
        Debug.Log("Saved");
    }
}
