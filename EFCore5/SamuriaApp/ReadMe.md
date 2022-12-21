## Section 2: Building Your First Application using EF Core
* Setting up the Solution
* Adding EF Core with the NuGet Package Manager
* A Sneak Peek at Writing and Reading Data
## Section 3: Controlling Database Creation and Schema
* Adding Your First Migration
* *	Add-Migration init
* * Script-Migration
* * Update-Database -verbose
* Using Migrations to Script or Directly Create the Database
* Reverse Engineering an Existing Database
* * scaffold-dbcontext 
## Section 4: Defining Relationships in Your Model
* EF Core's Default Many-to-Many Mapping
* * Add-Migration manytomanysimple
* * Update-Database
* * Get-Migration
* Storing Additional Data with Many-to-Many Payloads
* Configuring the Many-to-Many Payload
* Migrating the Many-to-Many Payload
* * Table Mapping Conventions:
1. DbSet drives table name
2. If there is no DbSet, then table uses the name of the class
3. Override with ToTable mapping
* Adding a One-to-One Relationship
## Section 5: Interacting with Your EF Core Data Model
* Looking at SQL Built by EF Core