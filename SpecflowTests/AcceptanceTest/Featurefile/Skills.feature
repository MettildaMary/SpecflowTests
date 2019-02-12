Feature: Skills
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check if user could able to add a skill 
	Given I clicked on the skills tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

	@edit skill
	
	Scenario: Check if user could able to edit a skill
	Given I clicked on the skill tab 
	When I edit a new skill 
	Then that skill should be dispayed on my listing

	@delete skill
Scenario: check if user is able to delete a skill
  Given I click on Delete button of a skill
  Then language is deleted is from the skill