
/// INFORMATION
///
/// Project:
/// Game:
/// Data:
/// Author:
/// Programmers:
/// Description:
///
using UnityEngine.Events;

public class DamageBehaviour
{
    #region EVENT

    public static UnityEvent<float> OnTakeDamage = new UnityEvent<float>();
    #endregion

    #region PRIVATE VARIABLES

    private DataPlayer _data;
    #endregion

    #region CONSTRUCTOR

    public DamageBehaviour(DataPlayer data)
    {
        _data = data;
        ButtonApplayDamage.Action.AddListener(ApplayDamage);
    }

    ~DamageBehaviour()
    {
        ButtonApplayDamage.Action.RemoveListener(ApplayDamage);
    }
    #endregion

    #region OWN METHODS
    public void ApplayDamage(float damage)
    {
        if (damage < 0)
        {
            throw new NegativeValueException(string.Format("el daño no puede ser un valor negativo: {0}", damage));
        }
        _data.CurrentLife -= damage;
        if (OnTakeDamage == null) return;
            OnTakeDamage.Invoke(_data.CurrentLife);
    }
    #endregion
}