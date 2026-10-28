using UnityEngine;

public class CheckpointReceiver : MonoBehaviour
{
    [SerializeField]
    private Vector2[] checkpointsPosition;
    private int currentCheckpoint = 0;

    private void UnlockRun()
    {
        this.GetComponent<PlayerMovement>().MoveStats.canRun = true;
    }

    private void UnlockWallJump()
    {
        this.GetComponent<PlayerMovement>().MoveStats.canWallJump = true;
    }

    private void UnlockDash()
    {
        this.GetComponent<PlayerMovement>().MoveStats.NummberOfDashes = 1;
    }

    private void UnlockDbJump()
    {
        this.GetComponent<PlayerMovement>().MoveStats.NumberOfJumpsAllowed = 2;
    }

    private void UnlockDbDash()
    {
        this.GetComponent<PlayerMovement>().MoveStats.NummberOfDashes = 2;
    }

    private void UnlockGodMode()
    {
        this.GetComponent<PlayerMovement>().MoveStats.canRun = true;
        this.GetComponent<PlayerMovement>().MoveStats.canWallJump = true;
        this.GetComponent<PlayerMovement>().MoveStats.NumberOfJumpsAllowed = 5;
        this.GetComponent<PlayerMovement>().MoveStats.NummberOfDashes = 5;
    }
    public void nextCheckpoint(int newCheck)
    {
        if (currentCheckpoint < newCheck)
        {
            currentCheckpoint = newCheck;
            switch(newCheck)
            {
                case 1:
                    UnlockRun();
                    break;

                case 2:
                    UnlockWallJump();
                    break;

                case 3:
                    UnlockDash();
                    break;

                case 4:
                    UnlockDbJump();
                    break;

                case 5:
                    UnlockDbDash();
                    break;

                case 1001:
                    UnlockGodMode();
                    break;
            }

        }
    }

    public void resetPosition()
    {
        this.transform.position = new Vector3(checkpointsPosition[currentCheckpoint].x, checkpointsPosition[currentCheckpoint].y, 0);
    }

    void Awake()
    {
        this.GetComponent<PlayerMovement>().MoveStats.canRun = false;
        this.GetComponent<PlayerMovement>().MoveStats.canWallJump = false;
        this.GetComponent<PlayerMovement>().MoveStats.NumberOfJumpsAllowed = 1;
        this.GetComponent<PlayerMovement>().MoveStats.NummberOfDashes = 0;
    }
}
