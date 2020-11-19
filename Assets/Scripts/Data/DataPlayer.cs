/// INFORMATION
///
/// Project:
/// Game:
/// Data:
/// Author:
/// Programmers:
/// Description:
///
using UnityEngine;
[CreateAssetMenu(menuName = "Prototype/Data player")]
public class DataPlayer:ScriptableObject
{
    #region PRIVATE VARIABLE

    [SerializeField] private float _maxLife;

    [SerializeField] private float _currentLife;

    #endregion

    #region PROPERTIES

    public float VidaMaxima { get => _maxLife; }
    public float CurrentLife { get => _currentLife; set => _currentLife = value; }
    #endregion
}