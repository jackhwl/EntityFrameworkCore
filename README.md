# EntityFrameworkCore
# Entity Framework in the Enterprise
## Section 1. Architecting a Data Layer
* 1. Course Prerequisites 
* 2. Module and Course Overview
* 3. Just Say 'No' to Demoware
* 4. Architecture Footprint- Starting Point
* 5. Pros and Cons of Learning from Demoware
* 6. First Pass at Breaking Apart a Single-project Solution
* 7. Removing Entity Framework from the UI
* 8. Lessons from Bounded Contexts and Other DDD Patterns
* 9. Testing When EF6 is Involved
## Section 2. Understanding EF Encapsulation and the Great Repository Debates
* 2. Benefits to Encapsulating EF Code
* 3. Reusable Components and Separation of Concerns
* 4. DbSet is a Repository
* 5. Guidance for Using Repositories or Explicit Classes
* 6. Return IQueryable or IEnumerable-
## Section 3. Implementing Encapsulation Patterns with Entity Framework
* 3. Non-tracking Alternatives to a Generic FindByKey Method
* 4. Adding Eager Loading to the Generic Repository
* 5. Benefiting from Dependency Injection and Inversion of Control
* 6. Implementing an IoC Container in the App
* 7. Customized Encapsulation for Complex Behaviors

# Getting Started with Entity Framework 6
## Section 1. Creating a Code-based Model and Database
* Enable-Migrations
* Update-Database -script
* Update-Database -verbose
* 6. Using Code First Migrations to Create a Database
* 7. Migrating a Database When Your Model Changes
## Section 2. Using EF to Interact with Your Data
* 2. Inserting Objects
* 3. Querying Simple Objects
* 4. Updating Modified Objects
* 5. Retrieving Data with the Find and SqlQuery Methods
* 6. Deleting Simple Objects
* 7. Inserting Related Data
* 8. Loading Related Data
* 9. Projection Queries
## Section 3. Using EF in Your Applications
* 5. EF in an MVC5 Application
* 6. A Repository Designed for Disconnected Apps
* 7. Using the Disconnected Repository in the MVC5 App
* 8. Entity Framework and ASP.NET Web API
* 9. Using EF and the Web API in an Aurelia Web Site

# Advanced Entity Framework 6
## Section 2. Performance and Stability Improvements
* Faster Complilation of Enumerable.Contains
* Faster Mapping View Generation
* Ngen for Faster Startup
* Open Connections Can be re-used
* Create DBs That are more scalable and less prone to deadlocks
* Connection resiliency for transient database connections
* Digging into the connection resiliency feature
## Section 3. Stored Procedure Mappings for Code First
## Section 4. Custom Code First Conventions
## Section 5. More Code First Goodies
## Section 6. Enhancements to Code First Migrations
## Section 7. Improved Database Interaction
* Simple Database Logging with Log Property
* Tweaking the Log Functionality
* SQLCE Functions for LINQ Queries
* Introducing the Async EF6 Methods
* Demonstrating the Effect of Asynchronous EF6 Methods
* Perception and Performance Load Testing with Async EF6
## Section 8. Code-based DbContext Configurations and Interceptors
* Tap into the pipeline with interceptors
* Beyond the interceptor basics
* What stops does the DbCommandInterceptor Make in the Pipeline
* Building an interceptor for database logging
* Using Interceptors to solve complex problems
## Section 9. Sometimes, It's the Little Things
* EF6 and mocking frameworks
* Writing Tests to Mock Methods like DbSetFind
* Writing Tests to Mock LINQ Queries
* Nested Entities and Complex Types
* Fixing the Ambiguous Typse Problem
* Custom Equals vs. Change Tracker Equals
* Smarter LINQ to Entities Queries
* Yes You Can Haz Changes with HasChanges

## EF Core Power Tools
* [EF Core Power Tools](https://github.com/ErikEJ/EFCorePowerTools)
* [Get a Head Start with Entity Framework Core 5.0 with EF Core Power Tools ](https://www.youtube.com/watch?v=uph-AGyOd8c)