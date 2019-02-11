Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

	
	Background: Moving to Profile page

	Given i am in Profile page

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	
	@edit languagae
	
	Scenario: Check if user could able to edit a language
	Given I clicked on the Language tab 
	When I edit a new language 
	Then that language should be dispayed on my listing


	@delete language
Scenario: check if user is able to delete a language
  Given I click on Delete button of a language
  Then language is deleted is from the listings
 
