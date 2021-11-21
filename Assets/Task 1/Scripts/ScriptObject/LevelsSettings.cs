using UnityEngine;

[CreateAssetMenu]
public class LevelsSettings : ScriptableObject
{
    [SerializeField] private int indexMenu = 0;
    [SerializeField] private int indexStartLevels = 1;
    [SerializeField] private int countLevels;

    public int IndexMenu => indexMenu;

    public int IndexStartLevels => indexStartLevels;

    public int CountLevels => countLevels;
    
}