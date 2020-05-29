Feature: PostItem
	In order to be a guru tester
	I want to automate the post item page
	Which has lots of features to automate in future


@mytag
Scenario: Verify Post Item
Given I navigate to the site "https://www.qa.giftrete.com"
    And I click on Signin
	When I enter Emailaddress 
	And I enter Password 
	And I click on Signin button
	And I click on PostItem
	And I enter ItemName
	And I enter ItemDescription 
	And I select ItemCategory
	And I select ItemType 
	And I enter ItemWeight
	And I enter Location 
	And I upload image
	And I click on add item
	Then Item image is displayed

	
