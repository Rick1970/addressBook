# _addressBook_

#### _Interactive application, that that allows user to input new contact info, that is saved on a contacts page.  The user has the ability to clear all contacts at their request._

#### By _**Rick Thornbrugh.**_

## Description

_User starts at welcome page with links to an input page, and a view contacts page.  If input is selected, they are moved to a form that allows them to input name, address, and phone number.  Upon submit the user is redirected to a congratulations page; displaying their new contact.  From here they can add another contact, or see all contacts.  If they choose to view all their contacts, they select that link, and are redirected to all contacts page.  At the bottom of this page the user is given the option to add more contacts, or clear all contacts.  If they choose clear all contacts, they are redirected to a page that says all contacts have been cleared._

## Setup/Installation Requirements

_File can be cloned from Github @ [https://github.com/Rick1970/addressBook].
Created in C# with atom text editor.  Used Nancy framework, and razor view engine.  To run the file after download; run the kestrel server by typing dnx kestrel._

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
| Directs user to home page with links to other pages | "Welcome to address book" | user clicks "enter new contact", or "see all contacts".
| User selects enter new contact, and is redirected to form with input| click add new contact. | redirects to new contact page.
| Form collects data, and saves to new page| enter new contact; and submit| redirects to congrats page; displaying new contact
| User can click see all contacts page| click all contacts| redirect to page with all contacts
| On all contacts page; user has the option of clearing all contacts, or returning to enter contacts| click clear contacts | redirected to page that says all contacts are cleared


## Known Bugs

_None known._

## Support and contact details

_Contact the author at [rthornbrug@gmail.com]._

## Technologies Used

_Atom text editor, in C#, with Nancy framework and razor view engine, running on Kestrel server._

### License

*MIT License

*Copyright (c) [2016] [Rick T
