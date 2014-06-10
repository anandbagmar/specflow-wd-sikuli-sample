Feature: Google Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@google
Scenario: Search for my blog
	And I am on the google search page
	When I search for 'essenceoftesting'
	Then I see a list of related posts

