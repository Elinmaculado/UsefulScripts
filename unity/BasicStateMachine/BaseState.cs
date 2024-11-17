using UnityEngine;

public abstract class BaseState
{
    // declaramos m�todos para le comportamiento de cada estado
    // TODOS los estados tienen los comportamientos declarados en BaseState
    // Aqui s�lo lo declaramos, diremos que hace cada m�todo dentro del respectivo estado, por eso ponemos "abstract"
    // Necesitan el StateManager c�mo par�metro ya que StateManager es el contexto que le da info a todos los estados
    public abstract void EnterState(StateManager apple);
    public abstract void UpdateState(StateManager apple);
    public abstract void OnCollisionEnter(StateManager apple);
}
