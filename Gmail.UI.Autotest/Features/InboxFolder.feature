Feature: InboxFolder
	Description: This feature will test received emails at inbox folder

Background:
   Given I have navigated to Gmail page

@Test
Scenario Outline: Checking received emails
	When click at Compose button from sidebar
	 And populate alex@gmail.com as recipient, my_own@gmail.com as CC, <topic1> as subject, <msg1> as message body	
	 And send new message
	 And populate bob@gmail.com as recipient, my_own@gmail.com as CC, <topic2> as subject, <msg2> as message body
	 And send new message
	 And populate shoan@gmail.com as recipient, my_own@gmail.com as CC, <topic3> as subject, <msg3> as message body
	 And send new message
	 And open Inbox folder from sidebar
	Then verify that emails are received by checking Inbox folder

	Examples: 
	| topic1                   | msg1     | topic2                                | msg2     | topic3                     | msg3      |
	| Thank you and next steps | Congrats | You're invited to join at our project | Good job | reasons to hire to project | best deal |

