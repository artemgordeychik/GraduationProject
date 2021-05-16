Feature: UI_AUTH_001 - Authorisation
As a Cloud of Views user
I want complete authorisation
In order to get access to my Cloud of Views accaunt

Scenario: UI_AUTH_001 - Success_Authorisation
Given Cloud of Views is opened
When I go to the Sign In page
	And I try Sign In with 'test' user and 'test2N' password
Then Authorisation page is 'opened'
	And 'test' user signed in