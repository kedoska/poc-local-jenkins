Feature: Onboarding
	
	The onboarding feature ensures new employees are added to the system as soon they
	join the company. This feature is only available to HR employees.

@core
Scenario: Send first day invitation
	Given I am an HR employee
	When A new employee is listed to start on a given date
	Then I should approve the sending of an invitation to the new employee
	