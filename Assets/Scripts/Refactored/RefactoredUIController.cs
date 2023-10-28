using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefactoredUIController : UIControllerBase
{
    private void Start()
    {
        RefactoredGameController.Instance.OnGameOver += HandleGameOver;
        RefactoredGameController.Instance.OnShot += HandleShot;

    }

    private void HandleGameOver()
    {
        gameOverGroup?.SetActive(true);

    }

    private void HandleShot()
    {
        if (shotsCountLabel != null)
        {
            shotsCountLabel.text = RefactoredGameController.Instance.RemainingArrows.ToString();

        }

        if (scoreCountLabel != null)
        {
            scoreCountLabel.text = RefactoredGameController.Instance.Score.ToString();
        }
    }
}
