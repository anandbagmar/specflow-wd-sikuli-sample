Feature: Google Search - 2nd feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@google
Scenario: Search for my TTA
	Given I am on the google search page
	When I search for 'tta'
    Then I should see at least '500' search results found