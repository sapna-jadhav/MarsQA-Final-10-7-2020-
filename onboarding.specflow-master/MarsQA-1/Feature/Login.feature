Feature: Login
	Login to the Profile Page with Valid username and Password

@Login
Scenario: Login to Profile Page
	Given I have open the browser and I have navigated to the url
	When I provide correct user name and password and press sign in
	Then I succesfully login to home page
