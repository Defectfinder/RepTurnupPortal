Feature: TMfeature

As a TurnUp portal user
I would like to create,edit and delete time and material record
So that manage employees time and material successfully

@regression
Scenario: create time record with valid data
	Given I logged into turnup portal successfully
	When  Nagaviate to time and material page
	When  create time record
	Then  the record should be created successfully
