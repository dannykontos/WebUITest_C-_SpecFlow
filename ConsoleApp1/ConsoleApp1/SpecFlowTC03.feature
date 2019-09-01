Feature: REQ-UI-03 - When I click on the Home button, I should get navigated to the Home page

Scenario:	I should be on the Home Page
	Given I navigate to http://uitest.duodecadits.com/form.html
	When  I click on home button
	Then  I should be on the home Page
	And   I close the browser
