
public class Wizard
{


    public Wizard()
    {
        Progress = 0;
        Step = 0;
        SetNavButtons();
    }

    public double Progress { get; private set; }

    public int Step { get; private set; }

    public bool PreviousButtonDisabled { get; private set; }
    public bool NextButtonDisabled { get; private set; }

    public void GoToNextStep()
    {
        Step += 1;            
        Progress += .2;
        if (Step == 6)
        {
            Progress = 100;
        }
        SetNavButtons();
    }

    public void GoToPreviousStep()
    {
        if (Step >= 1)
        {
            Step -= 1;
            Progress -= .2;
        }
        if (Step == 0)
        {
            Progress = 0;
        }
        SetNavButtons();
    }

    public void SetNavButtons()
    {
        NextButtonDisabled = false;
        switch (Step)
        {
            case 0:
                PreviousButtonDisabled = true;
                 break;
            case 1:
                PreviousButtonDisabled = false;               
                break;
            case 2:
                PreviousButtonDisabled = false;
                break;
            case 3:
                PreviousButtonDisabled = false;
                break;
            case 4:
                PreviousButtonDisabled = false;
                break;
            case 5:
                NextButtonDisabled = true;
                break;
            default:
                break;
        }
    }
}
