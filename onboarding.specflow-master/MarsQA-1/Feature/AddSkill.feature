Feature: AddSkill

A short summary of the feature

@addSkill
Scenario: Adding skills details in the form
	Given I have logged in with valid credentials
	When I try to add Skills details
	Then Skills gets added successfully
