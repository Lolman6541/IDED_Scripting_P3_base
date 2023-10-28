using UnityEngine;

public class RefactoredPlayerController : PlayerControllerBase
{
    public static RefactoredPlayerController Instance { get; private set; }

    
    protected override void Start()
    {
        base.Start();
        Instance = this;
    }

    protected override void ProcessShot(Vector3 point)
    {
        ICommand shotCommand = new ShotCommand(point);
        CommandManager.Instance.Execute(shotCommand)
    }
}