# Task 310. API Server "School"

> Realized with love :hearts: :computer:

<div align="center">

<img src="screenshots/interface.PNG" alt="drawing" width="1000"/>
<img src="screenshots/schemas.PNG" alt="drawing" width="1000"/>

---

</div>

## Usage

First, make sure to have dotnet downloaded and installed .NET SDK.

Now, clone the git repository, then navigate into it

### In CMD

```
cd School.API/

dotnet run
```

### In Visual Studio
```
open *.sln in Visual Studio
```

## Task

We need a service that implements the API and handles the following requests, and has a Swagger UI to test the API of all requests:

1. [GET] - Get the list of all students in JSON form
2. [GET] - Get a list of all employees as JSON
3. [GET] - Get list of students by class as JSON
4. [GET] - Get list of employees by job title as JSON
5. [POST] - Add a student
6. [POST] - Add a employee
7. [PUT] - Update a student
8. [PUT] - Update an employee
9. [DELETE] - Delete a student
10. [DELETE] - Delete an employee

### Student schema

```json
{
	"id" : 0, // > 0
	"document" :
	{
		"id" : 0, // document number depends on the type
		"idType" : "string", // id, birth certificate, passport
		"firstName" : "string",
		"secondName" : "string",
		"patronymic" : "string", // patronymic
	}
	"class" :
	{
		"id" : 0, // document number depends on the type
		"name" : "string", // 1A, 2B, 3C, 4D ...
		"classRoom" :
		{
			"id" : 0, // document number depends on the type
			"name" : "string",
			"number" : 0,
			"floor" : 0, // floor
			"build" : 0 // building
		},
		"students" :
		[
			{
				"id" : 0, // > 0
				"document" :
				{
					"id" : 0, // document number depends on the type
					"idType" : "string", // id, birth certificate, passport
					"firstName" : "string",
					"secondName" : "string",
					"patronymic" : "string", // patronymic
				}
				"averageRating" : 0.0
			}
		],
	},
	"averageRating" : 0.0
}
```

### Emoployee schema

```json
{
	"id" : 0, // > 0
	"document" :
	{
		"id" : 0, // document number depends on the type
		"idType" : "string", // id, birth certificate, passport
		"firstName" : "string",
		"secondName" : "string",
		"patronymic" : "string", // patronymic
	},
	"jobTitle" : "string", // position: Teacher, Security Guard, Janitor, Director....
}
```

### Document schema

```json
{
	"id" : 0, // document number depends on the type
	"idType" : "string", // id, birth certificate, passport
	"firstName" : "string",
	"secondName" : "string",
	"patronymic" : "string", // patronymic
}
```

### Cabinet schema

```json
{
	"id" : 0, // document number depends on the type
	"name" : "string",
	"number" : 0,
	"floor" : 0, // floor
	"build" : 0 // building
}
```

### Class schema

```json
{
	"id" : 0, // document number depends on the type
	"name" : "string", // 1A, 2B, 3C, 4D ...
	"classRoom" :
	{
		"id" : 0, // document number depends on the type
		"name" : "string",
		"number" : 0,
		"floor" : 0, // floor
		"build" : 0 // building
	},
	"students" :
	[
		{
			"id" : 0, // > 0
			"document" :
			{
				"id" : 0, // document number depends on the type
				"idType" : "string", // id, birth certificate, passport
				"firstName" : "string",
				"secondName" : "string",
				"patronymic" : "string", // patronymic
			}
			"averageRating" : 0.0
		}
	],
}
```
