using UnityEngine;

public class StateManager : MonoBehaviour
{
    //Es una referencia al estado en el que nos encontramos actualmente
    BaseState currentState;

    //Creamos instancias de los estados que tenemos
    public WholeState wholeState = new WholeState();
    public GrowingState growingState = new GrowingState();

    // CREO que les pasamos elementos de monobehaviour porque los otros scripts no son monobehaviour
    private void Start()
    {
        currentState = growingState;

        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this);
    }
}
