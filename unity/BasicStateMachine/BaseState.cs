using UnityEngine;

public abstract class BaseState
{
    // declaramos métodos para le comportamiento de cada estado
    // TODOS los estados tienen los comportamientos declarados en BaseState
    // Aqui sólo lo declaramos, diremos que hace cada método dentro del respectivo estado, por eso ponemos "abstract"
    // Necesitan el StateManager cómo parámetro ya que StateManager es el contexto que le da info a todos los estados
    public abstract void EnterState(StateManager apple);
    public abstract void UpdateState(StateManager apple);
    public abstract void OnCollisionEnter(StateManager apple);
    public abstract void ExitState(StateManager apple);
}
