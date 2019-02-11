Feature: Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag Availability
Scenario: Check if user can able to addd availability
	Given Click Edit icon 
	And Select availability
	Then the availability should display

	@hours
	Scenario: Check if user can able to add hours
	Given Click Edit icon for hours
	And Select hours
	Then the hours should be display

	@Earn target
	Scenario: Check if user can able to add earn target
	Given click Edit icon for Earn Target
	And select Earn Target
	Then the earn target should be dispaly

