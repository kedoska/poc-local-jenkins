namespace Example.Domain.Tests;

[Binding]
public class OnboardingTest
{
    [Given(@"I am an HR employee")]
    public void GivenIAmAnHrEmployee()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"A new employee is listed to start on a given date")]
    public void WhenANewEmployeeIsListedToStartOnAGivenDate()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"I should approve the sending of an invitation to the new employee")]
    public void ThenIShouldApproveTheSendingOfAnInvitationToTheNewEmployee()
    {
        ScenarioContext.StepIsPending();
    }
}