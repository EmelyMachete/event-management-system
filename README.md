Event Management System
ASP.NET Core MVC | C# | Entity Framework Core | SQL Server
Overview
The Event Management System is a database-driven web application designed to manage events through a structured and maintainable backend architecture. The system supports creating, viewing, updating, and deleting event records while enforcing data integrity and predictable application behavior.
This project was built to demonstrate sound software engineering fundamentals, including MVC separation of concerns, persistence using Entity Framework Core, and disciplined backend design suitable for enterprise web applications.
________________________________________
Problem Statement
Organizations often require simple internal systems to manage structured data such as events, schedules, or bookings. These systems must ensure correctness, validation, and maintainability rather than visual complexity.
This application addresses that need by providing a clean, server-side managed event system where data consistency and predictable behavior are prioritized.
________________________________________
Core Features
•	Create, view, edit, and delete events (CRUD)
•	SQL-backed persistence using Entity Framework Core
•	Server-side validation to prevent invalid application states
•	Structured MVC architecture separating concerns across layers
•	Code-first database migrations
________________________________________
Technology Stack
•	Language: C#
•	Framework: ASP.NET Core MVC
•	ORM: Entity Framework Core
•	Database: SQL Server
•	Architecture: Model–View–Controller (MVC)
________________________________________
System Design & Engineering Decisions
MVC Architecture
The application follows the MVC pattern to clearly separate responsibilities:
•	Models define the domain structure and validation rules
•	Controllers manage request handling and application flow
•	Views present data without embedding business logic
This separation improves maintainability, testability, and long-term extensibility.
Entity Framework Core
Entity Framework Core is used for:
•	Mapping domain models to relational tables
•	Managing schema evolution through code-first migrations
•	Ensuring consistency between application logic and stored data
Server-Side Validation
Validation rules are enforced at the model level to ensure:
•	Invalid data cannot be persisted
•	Application state remains consistent
•	Business rules are respected regardless of client behavior
________________________________________
Assumptions & Limitations
•	Single-user context (no authentication or role separation)
•	No external integrations (e.g. email, payments)
•	Designed for correctness and structure, not high-traffic scalability
•	UI kept intentionally simple to emphasize backend design
________________________________________
What I Would Improve Next
If this system were extended further, the next logical improvements would include:
•	User authentication and role-based access control
•	Audit logging for event changes
•	Pagination and filtering for large datasets
•	Deployment configuration for production environments
________________________________________
Outcome
This project demonstrates the ability to design and implement a stable, maintainable, database-driven web application aligned with enterprise development standards. The focus was placed on correctness, structure, and engineering discipline rather than surface-level features.


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
