Feature: REQ-UI-05 - When I click on the Form button, I should get navigated to the Form page

Scenario:	I click on form
	Given I navigate to http://uitest.duodecadits.com/
	When  I click on form button
	Then  I should be on the form Page
	And   I close the browser
