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
- SQL Server
- ADO.NET
- Guna2UI

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

- SHA-256 password hashing
- GUID-based login tokens encrypted with DPAPI and stored in the Windows Registry
- Bitwise permission system
- SQL parameterization and input validation
- Audit logging for important actions

---

## 📌 Business Rules

- Test order must follow: Vision, Theory then Street
- Duplicate active applications are not allowed
- License issuance requires all tests to be passed
- Users cannot schedule conflicting appointments
- License actions depend on status and validity
