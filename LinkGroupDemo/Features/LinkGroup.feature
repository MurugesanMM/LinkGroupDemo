Feature: Link Group

Scenario: Smoke test
When I open the home page
Then the page is displayed 


Scenario: Search results
Given i have agreed to the cookie policy
When I search for 'Leeds'
Then the search results are displayed

Scenario Outline: Investment managers
Given I have opened the Found Solutions page
When I view Funds
Then I can select the investment managers for <jurisdiction> investors

Examples:
|jurisdiction |
|UK           |
|Irish        |
|Swiss        |