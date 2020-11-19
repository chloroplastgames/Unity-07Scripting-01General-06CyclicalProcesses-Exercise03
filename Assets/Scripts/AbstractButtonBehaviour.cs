/// INFORMATION
///
/// Project:
/// Game:
/// Data:
/// Author:
/// Programmers:
/// Description:
///
 
using UnityEngine.EventSystems;
using UnityEngine; 
using UnityEngine.Events;

public abstract class AbstractButtonBehaviour : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _value;

    public static UnityEvent<float> Action = new UnityEvent<float>();

    public void OnPointerClick(PointerEventData eventData)
    {
        Action.Invoke(_value);
    } 
}
