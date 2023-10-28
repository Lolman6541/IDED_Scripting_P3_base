public interface ICommand
{
    void Execute();
}

public class ShotCommand : ICommand
{
    private Vector3 shotPosition;

    public ShotCommand(Vector3 position)
    {
        shotPosition = position;
    }

    public void Execute()
    {
        RefactoredGameController.Instance.ProcessShot(shotPosition);
    }
}