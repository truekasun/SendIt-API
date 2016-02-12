SendIt! - API
-------------
**SendIt - API** is a MVC Web API 2.0 application that allows to accept POST requests from the front-end and redistribute the email through Elastic Email servers.

>**Note:**
>Elastic Email is a powerful email platform built from the ground up to send your email more efficiently. You can signup with them with a free plan that allows send 25,000 emails per month.

SendIt API requires an Elastic Email account that provides an API key. Once you [**Signup**][1] with them, you may find the API key from the [**'Settings'**][2] tab in the dashboard.


----------
Getting Started
-------------
#### Step 1:
- You have to [signup][1] with Elastic Email in-order to have an API Key.
- Find your API key in the Settings tab in the Elastic Email [dashboard][2].

#### Step 2:
- Open the SendIt API solution with [Microsoft Visual Studio 2015][3].
- In the solution, there are 2 sub projects (HelperLayer, SendIt)
- Once you have the API key and the user account from the Elastic Email, set the API key and the username in **HelperLayer->Framework->Mailer.cs** class file.

#### Step 3:
- You can directly host (publish) the solution on windows azure or any other windows hosting (IIS).
- Or you can test the API within the localhost on your computer.

---
Test the API
-------------
#### Step 1:
- You may need a [REST/HTTP Client][4] or a well written JavaScript web application in-order to test the API.
- I use [POSTMAN][4] (a Google Chrome App) through this testing scenario
- Request method should be selected as **POST** since we are going to do a POST request to the API.
#### Step 2:
- URI should be the website address + /api/Send/ (**Ex:** http://localhost:10129/api/Send/)
- Then the HTTP Header 'Content-Type' should be set to 'application/json', since we pass a json object to the API action that we are going to call.
- Request body can contain following fields.

Name | Mandatory | Type | Description|
--- | --- | --- | --- |
| `From`|Yes| `string`| Sender's email address|
| `Name`|No| `string`| Sender's name |
| `To`|Yes| `string`|Recipient's email address |
| `Subject`|No| `string`|Subject of the email|
| `BodyHtml`|No| `string`|Body (if HTML) of the email|
| `BodyText`|No| `string`|Body (if only text) of the email|



![HTTP Headers](http://i.imgur.com/PPFaEVz.png)

![Body](http://i.imgur.com/GBrh81V.png)

---

#### Result:
- If the email sent **successfully**, the result looks like this

Name | Result |
--- | --- |
Status | `true` |
Message| `"f223a577-ff4c-40f6-994d-1bd2440c5d32"` |


---
- If there was an error, the result looks like this

Name | Result |
--- | --- |
Status | `false` |
Message| `"Error description"` |


---------

> **The MIT License (MIT)** 
> 
> Copyright (c) 2016, Kasun Jayarathna
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

>The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

>THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

---------

[1]: https://elasticemail.com/account#/create-account
[2]: https://elasticemail.com/account#/settings
[3]: https://www.visualstudio.com/
[4]: https://www.getpostman.com/
