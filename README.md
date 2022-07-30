Cloud Customers
==============

First C# practice, building a .NET 6 Web API from scratch using TDD


---

- this program is a simple http related service, that's proxying a request out to some configured url
- this program returns the result to the controller to pass the data back to our client as serialized json data
- all the business logic is isolated from the things that depended on it
- the program is covered by simple unit tests, following TDD approach
- the user can run this application and see it in action

![CloudCustomers_before](https://i.postimg.cc/ZR1Dsdmj/Screenshot-2022-07-24-at-19-33-13.png)

![CloudCustomers_after](https://i.postimg.cc/MH7ts3dK/Screenshot-2022-07-24-at-19-32-52.png)

---

## Covered in this project:

- .NET 6
- Web API Development
- TDD
- Unit Testing
- HttpClient
- .NET Dependency Injection
- Inversion of Control
- SOLID Design Principles
- REST APIs
- dotnet CLI

---

## How to install the program

- Clone this repository 
```
git clone https://github.com/amfibiya17/c-sharp-practice.git
```

---

## How to run the program

```
cd c-sharp-practice/CloudCustomers/CloudCustomers.API
dotnet run
```
and go to [localhost:7068/swagger/index.html](localhost:7068/swagger/index.html)

Or

- open the program with [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- click **run** from within Visual Studio, configure to use SSL to avoid you can choose to trust the self-signed certificate
- on the localhost page, which Visual Studio opens, you can see that "Swagger" shows the users endpoint
- press GET >> Try it out >> Execute

---

## Test Coverage

All tests are passing ✅ 

![Tests](https://i.postimg.cc/CK4hgw5j/Screenshot-2022-07-24-at-19-42-17.png)

---
