Feature: ManualTests
	As an user I would like to
	add details to my profile and be
	able to view them

@manual
Scenario: Login with invalid credentials
	Given I access Mars Portal
	And I input invalid credentials
	Then I should get an error message

Scenario: Signing out
	Given I click on the sign out button
	Then I should be taken to the home page

Scenario: Adding a description
	Given I add a description
	Then I should be able to see a confirmation message in a pop up

Scenario: Editing my description
	Given I edit my description
	Then I should be able to see a confirmation message in a pop up

Scenario: Adding description where the first character is not a digit or a letter
	Given I type in an exclamation point as the first character
	Then I should get an error message

Scenario: Adding availability
	Given I click on availability
	When I select one of the options available
	Then I should be able to see my availability in my profile

Scenario: Adding hours 
	Given I click on hours
	When I select one of the options available
	Then I should be able to see my hours in my profile
	
Scenario: Adding earn target
	Given I click on earn target
	When I select one of the options available
	Then I should be able to see my earn targets in my profile

Scenario: Adding a language record without selecting the language level
	Given I add a language record
	And I don't select a language level
	Then I should get an error message

Scenario: Adding a language record without typing a language
	Given I add a language record
	And I don't type in a language
	Then I should get an error message

Scenario: Adding a skill record without selecting the skill level
	Given I add a skill record
	And I don't select a skill level
	Then I should get an error message

Scenario: Adding a skill record without typing a skill
	Given I add a skill record
	And I don't type in a skill
	Then I should get an error message

Scenario: Adding an education record
	Given I add an education record
	When I click the add button
	Then I should get a confirmation message

Scenario: Adding an education record without typing the university name
	Given I add an education record
	And I don't type in the university name
	Then I should get an error message

Scenario: Adding an education record without selecting the university country
	Given I add an education record
	And I don't select the university country
	Then I should get an error message

Scenario: Adding an education record without selecting a title
	Given I add an education record
	And I don't select a title
	Then I should get an error message

Scenario: Adding an education record without typing the degree
	Given I add an education record
	And I don't type in the degree
	Then I should get an error message

Scenario: Adding an education record without selecting the graduation year
	Given I add an education record
	And I don't select graduation year
	Then I should get an error message

Scenario: Adding a certification record
	Given I add a certification record
	When I click on the add button
	Then I should get a confirmation message

Scenario: Adding a certification record without typing a certification
	Given I add a certification record
	And I don't type in a certification
	Then I should get an error message

Scenario: Adding a certification record without typing certified from
	Given I add a certification record
	And I don't type in certified from
	Then I should get an error message

Scenario: Adding a certification record without selecting a year
	Given I add a certification record
	And I don't select a year
	Then I should get an error message
