using UnityEngine;

public class RefactoredGameController : GameControllerBase
{
    
    public static RefactoredGameController Instance { get; private set; }

    public event System.Action OnGameOver;
    public event System.Action OnShot;
     
    
    [SerializeField]
     
    private int maxArrows = 10;

    private int remainingArrows;
    private int score;

    private GameState  currentState;

    private void Awake()
    {
        Instance = this;
        remainingArrows = maxArrows;
        currentState = new WaitingState(this);

    }

    private void Start()
    {


    }

    private void Update()
    {
        currentState.UpdateState();

    }

    public void ProcessShot(Vector3 point)
    {
        current.State.ProcessShot(point);

    }

    public void EndGame()
    {
        OnGameOver?.Invoke();
        currentState = new OnGameOverState(this);

    }

    public void FireShot()
    {
        remainingArrows--;
        OnShot?.Invoke();
        currentState = new ShotFiredState(this);

    }

}