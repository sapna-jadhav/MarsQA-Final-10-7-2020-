Feature: AddEditDeleteEducation

I have loged in with given credentials and try to add/Edit/Delete Education details

@AddEditDeleteEducation
Scenario: Adding Education details on profile Page
	Given I have logged in with username and pwd
	When I try to add Education details
	Then A Education details gets added successfully

	Scenario: Edit Education details on profile Page
	Given I have logged in and trying to edit Education details
	When I try to Edit Education details
	Then  Education details gets Updated Successfully

	Scenario: Deleting Education details on profile Page
	Given I have logged in and navigate to profile page
	When I try to delete Education details
	Then  Education details gets deleted successfully

