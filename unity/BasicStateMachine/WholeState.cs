using UnityEngine;

public class WholeState : BaseState
{
    // Agregamos override porque para el mismo método el comportamiento cambia en cada estado
    public override void EnterState(StateManager apple)
    {
        Debug.Log("La manzana creció");
        apple.GetComponent<Rigidbody>().useGravity = true;
        //rb.useGravity = true;
    }
    public override void UpdateState(StateManager apple)
    {
        
        
    }
    public override void OnCollisionEnter(StateManager apple)
    {
        apple.DestroySelf();
    }



    public override void ExitState(StateManager apple)
    {
        // Aqui debe ir comportamiento cómo terminar animaciones
        // reiniciar variables o cualquier comportamiento temporal
        Debug.Log("Se salió del estado: " + this.GetType().Name);
    }
}
