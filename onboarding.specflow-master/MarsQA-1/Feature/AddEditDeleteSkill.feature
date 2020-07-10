Feature: AddEditDeleteSkill
I have loged in with given credentials and try to add/Edit/Delete Skill Details

@AddEditDeleteSkill
Scenario: Adding new Skill Details
	Given I  logged in with valid credentials and navigate to profile page
	When I try to add Skill Details
	Then A Skill Details gets added Successfully


	Scenario: Edit Seller Skill Details
	Given I have logged in and trying to edit Skill Details
	When I try to Edit Skill Details
	Then  Skill Details gets Updated Successfully

	Scenario: Deleting Skill Details
	Given I have logged in with given credentails and im on the profile page
	When I try to delete Skill Details
	Then Skill Details gets deleted successfully

