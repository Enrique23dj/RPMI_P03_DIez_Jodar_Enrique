using UnityEditor.Build;
using UnityEngine;

public class CardStatController : MonoBehaviour
{
    //Los corchetes se usan para añadirle atributos a una variable
    //SerializeField es un atributo para que aunque esté en privado una variable se pueda ver y editar desde el editor
    //Tooltip es un atributo para añadirle una descripción a la variable que será visible desde el editor
    //Range es un atributo para añadir un rango máximo de valores que se puedan establecer desde el editor
    [SerializeField, Tooltip("Attack of the card"), Range(0, 9)]
    private int attack;

    public int GetAttack()
    {
        return attack;
    }
}
