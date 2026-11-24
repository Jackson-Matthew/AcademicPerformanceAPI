# Academic Performance API

A small ASP.NET Core Web API that works out a student's final mark for a module. You send it the assignment, test and exam marks. It checks they're between 0 and 100, weights them (30% assignment, 30% test, 40% exam) and returns the final mark with a result of Pass with Distinction, Pass or Fail.

**Built with:** C#, ASP.NET Core Web API (.NET 10), Swagger

## Running it

1. Install the [.NET 10 SDK](https://dotnet.microsoft.com/download)
2. Run it:
   ```bash
   dotnet run
   ```
3. Open http://localhost:5232/swagger to try the `POST /api/controller/Evaluate` endpoint

Example request body:

```json
{
  "id": 1,
  "studentName": "Jane",
  "moduleCode": "PROG6212",
  "assignmentMark": 70,
  "testMark": 65,
  "examMark": 80
}
```
