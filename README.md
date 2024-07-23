# ReverseStringAPI

This project is a simple ASP.NET Core Web API that provides functionalities to reverse a string and check if it is a palindrome.

## Requirements

- .NET 5.0 (or later)

## Setup

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore the NuGet packages.
4. Run the project.

## Usage

### Endpoint

`GET /api/string/process`

### Parameters

- `input`: The string to be processed.

### Response

```json
{
    "ReversedString": "gnitset",
    "IsPalindrome": false
}
