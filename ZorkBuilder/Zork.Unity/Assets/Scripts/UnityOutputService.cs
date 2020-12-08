using System;
using UnityEngine;
using UnityEngine.UI;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        outputText.text = value;
    }

    public void Write(object value)
    {
        Write(value.ToString());
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    [SerializeField]
    private Text outputText;
}
