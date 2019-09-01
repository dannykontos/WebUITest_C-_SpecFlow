Feature: REQ-UI-09 - The following text should be visible on the Home page in <h1> tag:
"Welcome to the Docler Holding QA Department"


Scenario:	I should get "Welcome to the Docler Holding QA Department" when looking for an <h1> tag
	Given I navigate to http://uitest.duodecadits.com/
	Then  The h1 tag contains Welcome to the Docler Holding QA Department
	And   I close the browser

