# Event Management System

## Overview
The Event Management System is a database-driven web application designed to manage events using a structured and maintainable backend architecture. The system supports creating, viewing, updating, and deleting event records while enforcing data integrity and predictable application behavior.

This project demonstrates core software engineering fundamentals, including proper MVC separation of concerns, persistence using Entity Framework Core, and disciplined backend design aligned with real-world enterprise standards.

## Problem Statement
Organizations often require simple internal systems to manage structured data such as events, schedules, or bookings. These systems must prioritize correctness, validation, and maintainability over visual complexity or unnecessary features.

This application addresses that need by providing a clean, server-managed event management system where data consistency and predictable behavior are central design goals.

## Core Features
- Full CRUD functionality for events
- SQL-backed persistence using Entity Framework Core
- Server-side validation to prevent invalid application states
- Code-first database migrations
- Clear MVC separation across models, views, and controllers

## Technology Stack
- Language: C#
- Framework: ASP.NET Core MVC
- ORM: Entity Framework Core
- Database: SQL Server
- Architecture: Model–View–Controller (MVC)

## System Design and Engineering Decisions
- The MVC architecture is used to separate domain models, application logic, and presentation concerns
- Entity Framework Core handles object–relational mapping and database schema evolution through migrations
- Validation rules are enforced at the model level to ensure data integrity regardless of client-side behavior
- Controller actions are kept explicit and readable to support maintainability and debugging

## Assumptions and Limitations
- Single-user context with no authentication or authorization
- No external integrations such as email, payments, or notifications
- Designed to demonstrate correctness and structure rather than high-scale deployment
- User interface kept intentionally simple to emphasize backend logic

## What I Would Improve Next
- User authentication and role-based access control
- Audit logging for event creation and updates
- Pagination and filtering for larger datasets
- Environment-based configuration and production-ready deployment

## Outcome
This project demonstrates the ability to design and implement a stable, maintainable, database-driven web application with a strong emphasis on correctness, structure, and backend engineering discipline.




---
## 📸 Screenshots

### Events List
![Events List](screenshots/events-list.png)

### Create Event
![Create Event](screenshots/create-event.png)

### Edit Event
![Edit Event](screenshots/edit-event.png)


## Author
**Emely Mokgadi Machete**  
Bachelor of IT  
Junior Software Developer  

📧 Email: macheteemely@gmail.com  
🔗 LinkedIn: https://www.linkedin.com/in/emelymachete  
💻 GitHub: https://github.com/EmelyMachete
