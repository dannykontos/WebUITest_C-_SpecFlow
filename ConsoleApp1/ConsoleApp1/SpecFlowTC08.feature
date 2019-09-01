Feature: REQ-UI-08 - When I click on the UI Testing button, I should get navigated to the Home page

Scenario:	I should navigate to Home page when I click UI Testing button
	Given I navigate to http://uitest.duodecadits.com/form.html
	When  I click on site button
	Then  I should be on the home Page
	And   I close the browser
