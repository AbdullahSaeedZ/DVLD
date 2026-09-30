# Driving Vehicles & Licenses Dept (DVLD)

**A driving license management system built with C#, ADO.NET, and SQL Server.**  
🔗 [Click For Full Details](https://abdullahsz.com/#/desktop-projects/dvld-system)
---

## 🎥 Demo (Click to watch on YouTube)

<p align="center">
  <a href="https://www.youtube.com/watch?v=Lfk3Hv5G4CU">
    <img src="https://img.youtube.com/vi/Lfk3Hv5G4CU/maxresdefault.jpg" />
  </a>
</p>

---

## 📝 Description

DVLD is a desktop application that simulates a governmental Driving and Vehicle Licensing department. It manages the process of driving services, including license applications, test appointments, issuing local and international licenses, renewals, replacements, and detained licenses.

The system follows a **3-Tier Architecture** with a SQL Server relational database to keep business logic separated from data access and the user interface.

---

## 🛠 Tech Stack

- C#
- .NET Framework
- WinForms
- Guna2UI
- ADO.NET
- Microsoft SQL Server
- Transact-SQL (T-SQL)

---

## 🏗️ Technical Implementation

### 1. 3-Tier Architecture
- **Presentation Layer (WinForms + Guna2UI):** Manages user interactions, form workflows, and display logic.
- **Business Logic Layer (BLL):** Enforces core department rules, fee calculations, and data validation.
- **Data Access Layer (DAL - ADO.NET):** Executes parameterized commands using `SqlConnection`, `SqlCommand`, and `SqlDataReader` with parameterized queries to prevent SQL injection.

### 2. T-SQL & Database Implementation
- **Stored Procedures:** Encapsulates CRUD and business operations in precompiled routines instead of inline SQL.
- **ACID Transactions:** Wraps multi-table operations in explicit transactions (`BEGIN TRAN` / `COMMIT` / `ROLLBACK`) with `TRY...CATCH` to avoid partial writes.
- **Aggregate Functions:** Computes summary metrics, counts, and financial totals directly in queries using functions like `COUNT`, `SUM`, and `MAX`.
- **Scalar User-Defined Functions:** Handles reusable value transformations and lookup calculations within the database.
- **Triggers:** Automates table-level updates and state enforcement upon data modifications.
- **Relational Integrity:** Uses primary keys, foreign keys, and default constraints to enforce valid relationships across tables.

### 3. System & File Logging
* **Windows Event Viewer:** Records application errors and critical exceptions to the native Windows Event Log.
* **Local File Logging:** Records application errors and critical exceptions to a size-capped text file for troubleshooting.
---

## 🗄 Database Schema

<p align="center">
  <img src="Database/DB Design Schema.png" width="100%">
</p>

---

## 📋 Main Features

- Secure login system with "Keep me logged in"
- User and permission management
- Full people and drivers management
- License issuing, renewal, replacement, detention, and release
- Vision, theory, and street test workflow
- Appointment scheduling and tracking
- Dashboard with system statistics
- License and application history tracking

---

## 🔒 Security

- **Credential Protection:** SHA-256 password hashing.
- **Secure Persistence:** Session tokens encrypted with Windows Data Protection API (DPAPI) and stored in the Windows Registry.
- **Authorization:** Bitwise flag permissions per user.
- **SQL Injection Defense:** Complete parameterized queries across all DAL operations with zero dynamic SQL concatenation.

---

## 📌 Business Rules Implemented

- A person cannot have more than one active new license application for the same license classification.
- Applications with linked records or transactions cannot be deleted.
- Only applications with a `New` status can be cancelled.
- A license is issued only after all required tests are passed.
- Tests must be completed sequentially: Vision then Theory then Practical (Street).
- Applicants cannot schedule a test if an active appointment for the same test type already exists.
- No additional appointments are allowed after passing a test type.
- Test appointments cannot be scheduled in the past.
- Due appointments cannot be modified.
- Not allowed to take tests of locked appointments, and recorded test results cannot be edited.
- Missed appointments are automatically locked by the system.
- Failed tests automatically generate a `Retake Test` application upon rescheduling.
- Driver records are created automatically after issuing a license for the first time and cannot be manually added or deleted.
- A person cannot have more than one user account.
- Only users with an `Active` status can log in to the system.
- International licenses require a valid active local license.
- Licenses can only be renewed if they are both expired and active.
- No operations are allowed on inactive licenses.
- A person cannot own two active licenses of the same classification.
- Only undetained licenses can be detained, and only detained licenses can be released.
