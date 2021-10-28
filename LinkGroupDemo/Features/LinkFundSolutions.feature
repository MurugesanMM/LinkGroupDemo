Feature: LinkFundSolutions
	

Scenario Outline: Investment managers
Given I have opened the Found Solutions page
When I view Funds
Then I can select the investment managers for <jurisdiction> investors

Examples:
|jurisdiction |
|UK           |
|Irish        |
|Swiss        |