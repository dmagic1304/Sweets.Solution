# _Pierre's Sweet and Savory Treats_

#### By _**Dominik Magic**_

#### _A web application managing treats and flawors with authorization._<p>&nbsp;</p>  

## Technologies Used

- HTML
- Bootstrap
- C#
- .NET 5.0
- ASP.Net
- Razor
- MySQL
- MySQL Workbench
- EF Core
- Dotnet EF 6.0.1
- AspNetCore Identity

## Description

_The application allows the user to add treats and flavors to the database and create many-to-many relationships. The aplication implements authorization and user login. Only logged in users will be able to create, update or delete items from database._

## Setup/Installation Requirements

* _Clone [this](https://github.com/dmagic1304/Sweets.Solution) repositiory to your desktop_
* _Using your terminal, navigate to the cloned project folder located on your desktop_
* _Once inside of the root folder, first create .gitignore file with "touch .gitignore" command and then use "echo "*/obj/ */bin/ */appsettings.json" > .gitignore" command to ignore necessary folders/files_
* _Now navigate to Sweets folder with "cd Sweets" and then create appsettings.json file with "touch appsettings.json" command. Use the following command to fill the file with necessary data (make sure to ender your personal MySQL password instead of [YOURPASSWORD]):
```
echo '{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=sweets;uid=root;pwd=[YOURPASSWORD];"
    }
  }' > appsettings.json
```  
* _Next, in the same "root/Sweets" directory, run the following command: "dotnet ef database update" to create the database_

* _To run the application, make sure you are in  "root/Sweets" folder using your terminal and once there, run "dotnet run" command in the terminal. Once you see in your terminal that the server is running, go to the following URL using your internet browser http://localhost:5000_

* _To be able to create, update or delete items, make sure you are signed in_



## Known Bugs

* _No known bugs at this time_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) _2023_ _Dominik Magic_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.