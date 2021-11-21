using System;
using UnityEngine;

public class ListLevel : MonoBehaviour
{
    [SerializeField] private LevelsSettings levelsSettings;

    [SerializeField] private ElementLevel prefabButton;

    private Transform _transform;
    private bool isGenerate;

    private void Awake()
    {
        _transform = transform;
        isGenerate = false;
    }

    private void OnEnable()
    {
        if (isGenerate) return;
        CreateButtonsLevels();
        isGenerate = true;
    }

    private void CreateButtonsLevels()
    {
        var index = levelsSettings.IndexStartLevels;

        while (index <= levelsSettings.CountLevels)
        {
            CreateButton(index);
            index++;
        }
    }

    private void CreateButton(int index)
    {
        var clone = Instantiate(prefabButton, _transform);
        clone.SetIndex(index);
    }
}