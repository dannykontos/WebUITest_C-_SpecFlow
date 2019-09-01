Feature: REQ-UI-10 - The following text should be visible on the Home page in <p> tag:
"This site is dedicated to perform some exercises and demonstrate automated web testing."

Scenario:	I should get "Welcome to the Docler Holding QA Department" when looking for an <h1> tag
	Given I navigate to http://uitest.duodecadits.com/
	Then  The p tag contains This site is dedicated to perform some exercises and demonstrate automated web testing.       
	And   I close the browser
