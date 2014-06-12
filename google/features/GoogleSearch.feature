Feature: Google Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@google
Scenario: Search for my blog
	Given I am on the google search page
	When I search for 'essenceoftesting'
	Then I see a list of related posts

@google
Scenario: Search for my waat
	Given I am on the google search page
	When I search for 'waat'
	Then I should see at least '5000' search results found
