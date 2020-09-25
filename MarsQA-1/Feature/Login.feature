Feature: Login
	As an user I want to be able to log in
	to the Mars Portal

@automate
Scenario: Signing in
	Given I login to Mars Portal using valid credentials <username>, <password>
	Then I should be able to validade I logged into the portal successfully

	Examples:
		| username              | password        |
		| bmacedo1987@gmail.com | industryconnect |



		