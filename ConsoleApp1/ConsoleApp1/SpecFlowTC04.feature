Feature: REQ-UI-04 - When I click on the Home button, it should turn to active status

Scenario:	I see the Home button active 
	Given I navigate to http://uitest.duodecadits.com/form.html
	When  I click on home button
	Then  I see the Home button active
	And   I close the browser

