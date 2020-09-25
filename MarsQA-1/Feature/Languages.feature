Feature:2_Languages
	As a user I would like to
	add, edit and delete language
	records and view them in my
	profile page

	Scenario Outline: 1_Add a new language
		Given I click on Add New button
		And I enter language details <language>, <languageDetails>
		When I click on Add button
		Then I should be able to see a new language record created

		Examples:
			| language   | languageLevel    |
			| English    | Fluent           |

	Scenario Outline: 2_Edit an existent language record
		Given I click on the Edit icon
		And I edit existent record
		When I click on Update button
		Then I should be able to see the existent record updated

	Scenario Outline: 3_Delete existent language record
		Given I click on delete icon
		Then I should be able to validate that existent language record has been deleted

