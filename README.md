# ToDoListApp
app

## Getting Started
### Prerequisites
You will need the following tools:

* [Visual Studio Code or 2017](https://www.visualstudio.com/downloads/)
* [.NET Core SDK 2.2](https://www.microsoft.com/net/download/dotnet-core/2.2)

### Setup
Follow these steps to get your development environment set up:

  1. Clone the repository
  2. At the root directory, restore packages:
     ```
     dotnet restore
     ```
  3. Build the solution:
     ```
     dotnet build
     ```
  5. Launch app in the directory ToDoListApp :
     ```
	  dotnet run
	   ```

Or just simply open the solution and launch kestrel within visual studio

[![launch.png](https://i.postimg.cc/FKxs6Zjq/launch.png)](https://postimg.cc/7CfkGStM)

Database should be already updated to use existing migrations, but if it isn't, 
```
Database-Update
```
in package manager console. But it shouldn't
