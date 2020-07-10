Feature: AddEditDeleteLanguage

I have loged in with given credentials and try to add/Edit/Delete seller profile

@AddEditDeleteLanguage
Scenario: Adding new Seller Language Details on profile page

	Given I logged in with valid credentails
	When I try to add new language on the profile page
	Then A new language gets added successfully

Scenario: Edit new Seller Language Details on profile page
	
	When I try to Edit language Details 
	Then A Seller Language gets Updated Successfully

Scenario:Delete new Seller Language Details on profile page
	
	When I try to delete Seller language details
	Then The Seller language deatils gets deleted successfully
