# Address Book #
## By Jonathan Stein ##
## _A site that allows the user to create and edit contacts_ ##

### _Specifications_ ###

User inputs contact specifics in a a form, and contact is added to a list of contacts
- Input example: Name: Jonathan Stein, Phone: 425-214-6105

User is able to view list of contacts formatted on the Index page
- Input: User clicks "Show contacts button"
- Output: User is taken to index and contacts are each displayed individually with corresponding properties

User can view details of contact
- Input: User clicks a contact
- Output: User can see all the properties of that contact

User is able to edit contacts
- Input: User clicks a contacts name and changes a property in a form
- Output: When form is submitted, the user sees the updated contact information

### _Content_ ###

Index.cshtml:
- Splash page/where list of contacts is shown
ContactNew.cshtml:
- Shows the new contact a user has created right after they create it
ContactForm.cshtml:
- Where a user can input contact information to create a new contact
ContactDetails.cshtml:
- See/Edit the details of a contact
ClearConfirmation.cshtml:
- Page that appears when a user has cleared the address book of all contacts

Other:
- Address.cs: The Address class the Contacts use
- Contact.cs
- HomeController.cs
- Layout.cshtml

### _How to use_ ###

1. Download project from GitHub: https://github.com/JStein92/address_book
2. Run HTML in preferred browser
3. Follow instructions on page
  - Create a new contact
  - Edit existing contacts
  - Delete contacts

#### _Legal Information_ ####
Copyright (c) 2017 Copyright Holder All Rights Reserved.
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so.

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
