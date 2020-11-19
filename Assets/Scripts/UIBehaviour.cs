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
using UnityEngine.UI;

public class UIBehaviour: MonoBehaviour
{ 
    #region PRIVATE VARIABLES

    [SerializeField] private Text _uiLife;
    #endregion

    #region UNITY METHODS

    private void OnEnable()
    {
        DamageBehaviour.OnTakeDamage.AddListener(ShowDamage);
    } 
    private void OnDisable()
    {
        DamageBehaviour.OnTakeDamage.RemoveListener(ShowDamage);
    }
    #endregion

    #region OWN METHODS
    public void ShowDamage(float CurrentLife)
    { 
        _uiLife.text = CurrentLife.ToString(); 
    }
    #endregion
}
