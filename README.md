# Oracle EF Core Project

## Overview

This is a basic project demonstrating how to use an Oracle database with Entity Framework Core (EF Core) using the Code First migration approach. The project is built with .NET 8.0 and utilizes Oracle's database system for data storage.

## Technologies Used

- **.NET Version:** 8.0
- **Database:** Oracle Database 12c
- **ORM:** Entity Framework Core
- **Migration Strategy:** Code First

## Packages Installed

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Oracle.EntityFrameworkCore` (for Oracle database support)

## Setup Instructions

### Prerequisites

1. Ensure that you have .NET 8.0 SDK installed.
2. Install Oracle Database or use an existing Oracle Database instance.
3. Install SQL*Plus for managing the Oracle Database.

### Database Setup

1. **Create and Configure Oracle User:**

   Open `sqlplus` command-line tool and execute the following commands to create and configure a new Oracle user:

   ```plaintext
   C:\Windows\System32>sqlplus sys as sysdba

   SQL*Plus: Release 12.1.0.2.0 Production on Fri Aug 9 17:57:53 2024

   Copyright (c) 1982, 2014, Oracle.  All rights reserved.

   Enter password:

   Connected to:
   Oracle Database 12c Enterprise Edition Release 12.1.0.2.0 - 64bit Production
   With the Partitioning, OLAP, Advanced Analytics and Real Application Testing options

   SQL> drop user sampleuser cascade;
   drop user sampleuser cascade
   *
   ERROR at line 1:
   ORA-28014: cannot drop administrative users

   SQL> alter session set "_oracle_script"=true;

   Session altered.

   SQL> drop user sampleuser cascade;

   User dropped.

   SQL> create user sampleuser identified by pass123;

   User created.

   SQL> grant dba to sampleuser;

   Grant succeeded.

   SQL> exit
   Disconnected from Oracle Database 12c Enterprise Edition Release 12.1.0.2.0 - 64bit Production
   With the Partitioning, OLAP, Advanced Analytics and Real Application Testing options

   C:\Windows\System32>sqlplus

   SQL*Plus: Release 12.1.0.2.0 Production on Fri Aug 9 17:59:46 2024

   Copyright (c) 1982, 2014, Oracle.  All rights reserved.

   Enter user-name: sampleuser
   Enter password:

   Connected to:
   Oracle Database 12c Enterprise Edition Release 12.1.0.2.0 - 64bit Production
   With the Partitioning, OLAP, Advanced Analytics and Real Application Testing options

   SQL> select table_name from user_tables;

   no rows selected

   SQL> select table_name from user_tables;

   TABLE_NAME
   --------------------------------------------------------------------------------
   __EFMigrationsHistory
   Departments
   Employees
