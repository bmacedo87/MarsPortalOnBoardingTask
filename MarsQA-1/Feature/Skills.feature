Feature:3_Skills
	As a user I would like to
	be able to add, edit and delete
	skills records and view them
	in my profile page


Background: 
	Given I click on the Skills tab

	@automate
	Scenario Outline: 1_Add a new Skill record
		Given I click on Add New skills button
		And I add a new skill to my profile <skill>, <skillLevel>
		When I click on Add skill button
		Then I should be able to see a new skill record added

		Examples: 
			| skill | skillLevel |
			| C#    | Beginner   |

	Scenario Outline: 2_Edit an existent Skill record
		Given I click on Edit Skill icon
		And I update an existent Skill record
		When I click on Update Skill button
		Then I should be able to see the existent Skill record updated

	Scenario Outline: 3_Delete an existent Skill record
		Given I click on the Delete Skill button
		Then I should be able to validate that existent skill record has been deleted