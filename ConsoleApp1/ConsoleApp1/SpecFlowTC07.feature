Feature: REQ-UI-07 - When I click on the Error button, I should get a 404 HTTP response code

Scenario:	I see the error code
	Given I navigate to http://uitest.duodecadits.com/
	When  I click on error button
	Then  I get 404 error
	And   I close the browser

