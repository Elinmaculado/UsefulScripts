using UnityEngine;

public class GrowingState : BaseState
{
    Vector3 growthRate = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 startSize = new Vector3(0.1f, 0.1f, 0.1f);
    // Agregamos override porque para el mismo m�todo el comportamiento cambia en cada estado
    public override void EnterState(StateManager apple)
    {
        Debug.Log("entro al estado Grow");
        apple.transform.localScale = startSize;
    }
    public override void UpdateState(StateManager apple)
    {
        Debug.Log("update del estado Grow");
        if (apple.transform.localScale.x < 1)
        {
            apple.transform.localScale += growthRate * Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.wholeState);
        }

    }

    public override void OnCollisionEnter(StateManager apple)
    {

    }

}