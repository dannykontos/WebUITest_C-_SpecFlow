Feature: REQ-UI-01 - The Title should be "UI Testing Site" on every site

Scenario:	Check title on Homepage
	Given I navigate to http://uitest.duodecadits.com/
	Then The title is UI Testing Site
	And I close the browser

Scenario:	Check title on Form
	Given I navigate to http://uitest.duodecadits.com/form.html
	Then The title is UI Testing Site
	And I close the browser