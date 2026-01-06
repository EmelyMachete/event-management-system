# Event Management System

## Overview
The Event Management System is a database-driven web application designed to manage events using a structured and maintainable backend architecture. The system supports creating, viewing, updating, and deleting event records while enforcing data integrity and predictable application behavior.

This project demonstrates core software engineering fundamentals, including MVC separation of concerns, persistence using Entity Framework Core, and disciplined backend design.

## Problem Statement
Organizations often require simple internal systems to manage structured data such as events or schedules. These systems must prioritize correctness, validation, and maintainability over visual complexity.

This application provides a clean, server-managed solution where data consistency and predictable behavior are central design goals.

## Core Features
- Create, view, update, and delete events
- SQL persistence using Entity Framework Core
- Server-side validation
- Code-first database migrations
- Clear MVC separation of concerns

## Technology Stack
- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server

## Design Decisions
- MVC architecture separates data, logic, and presentation
- Entity Framework Core manages persistence and schema changes
- Validation is enforced at the model level to protect data integrity

## Limitations
- No authentication or authorization
- Single-user context
- UI kept simple to emphasize backend structure

## Future Improvements
- User authentication and roles
- Audit logging
- Pagination and filtering

## Outcome
This project demonstrates structured backend design, disciplined use of MVC, and reliable database-driven application behavior.



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
