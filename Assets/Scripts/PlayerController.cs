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

public class PlayerController : MonoBehaviour
{ 
    #region PRIVATE VARIABLES 

    private DamageBehaviour _damageBehaviour;

    [SerializeField] private DataPlayer _dataPlayer;
    #endregion

    #region UNITY METHODS 
    void Start()
    { 
        _damageBehaviour = new DamageBehaviour(_dataPlayer);
    }  
    #endregion

}
