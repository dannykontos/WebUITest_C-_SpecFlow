Feature: REQ-UI-12 - On the Form page, if you type <value> the input field and submit the form, 
you should get redirect to the Hello page, and the following text should appear: <result>

Scenario Outline: Submit the form
	Given I navigate to http://uitest.duodecadits.com/form.html
	And   I type <start> in the input field and click Submit
	Then  I should see <left> on the page
	And   I close the browser

  Examples:
    |  start	|  left				|
    |  John		|  Hello John!		|
    |  Sophia   |  Hello Sophia!	|
	|  Charlie  |  Hello Charlie!	|
	|  Emily    |  Hello Emily!		|