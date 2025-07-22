# ServiceDeskCRM

## 👨‍💻 Developer
**Mohammad Ibrahim Saleem**

## Overview
ServiceDeskCRM is a full-stack Service Desk and Ticket Management application built with ASP.NET Core backend and Angular frontend. It provides a comprehensive solution for tracking, managing, and resolving support tickets.

## 🏆 Project Highlights
- Developed a high-performance Help-Desk Ticketing Platform
- Implemented CRUD REST endpoints with Angular forms
- Features:
  - Ticket creation, assignment, and closure
  - Automatic ticket ID generation
  - Bookmarking functionality
  - Change approval workflow
- Performance: Load-tested to handle 500 requests per second

## 🚀 Features
- User Authentication
- Ticket Creation and Management
- Ticket Bookmarking
- Ticket Search and Filtering
- Dashboard with Ticket Overview
- Resolution Tracking

## 🛠 Technologies
### Backend
- ASP.NET Core 3.1
- Entity Framework Core
- SQL Server

### Frontend
- Angular 12
- TypeScript
- Bootstrap

## 📦 Project Structure
```
ServiceDeskCRM/
├── ServiceDeskBackEnd/
│   ├── Controllers/
│   │   ├── BookMarkedController.cs
│   │   ├── ResolutionController.cs
│   │   └── TicketController.cs
│   ├── Models/
│   │   ├── BookMarked.cs
│   │   ├── Resolution.cs
│   │   ├── ServiceDeskDBContext.cs
│   │   └── Ticket.cs
│   └── Migrations/
│
└── ServiceDeskFrontEnd/
    ├── src/
    │   ├── app/
    │   │   ├── dashboard/
    │   │   ├── tickets/
    │   │   ├── ticketdetails/
    │   │   └── loginpage/
    │   └── environments/
```

## 🔧 Setup and Installation

### Prerequisites
- .NET Core SDK 3.1
- Node.js and npm
- Angular CLI
- SQL Server

### Backend Setup
1. Navigate to `ServiceDeskBackEnd`
2. Update connection string in `appsettings.json`
3. Run database migrations:
   ```
   dotnet ef database update
   ```
4. Run the backend:
   ```
   dotnet run
   ```

### Frontend Setup
1. Navigate to `ServiceDeskFrontEnd`
2. Install dependencies:
   ```
   npm install
   ```
3. Start the development server:
   ```
   ng serve
   ```

## 🌐 Application Flow
1. Login to the application
2. View ticket dashboard
3. Create new tickets
4. Search and filter tickets
5. Bookmark important tickets
6. View ticket details
7. Resolve tickets

## 🤝 Contributing
1. Fork the repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📄 License
This project is open-source. Please check the LICENSE file for details.

## 📞 Support
For any issues or questions, please open a GitHub issue.