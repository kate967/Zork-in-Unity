using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService output;

    private void Awake()
    {
        TextAsset gameJsonAsset =  Resources.Load<TextAsset>(ZorkGameFileAssetName);

        Game.Start(gameJsonAsset.text, output);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
