📌 Task Management System — ASP.NET Core + SQL Server

This is a collaborative task management platform built using ASP.NET Core Web API and MS SQL Server, designed to handle task assignment, project planning, task panels, guest access, attachments, and discussion threads.

🚀 Features

Project Management

Create and manage projects

Define timelines

Track progress

Task Management

Assign tasks to users

Set start/end dates

Update task status

Add descriptions & metadata

Task Panels (Boards)

Group tasks under panels (similar to Kanban boards)

Share panels with other users

Guests can join/leave

Invitations System

Invite users to collaborate via email

Track status: Sent, In-Progress, Accepted

Discussions

Thread-style task discussions

User mentions & commenting support

Attachments

File uploads for Task / Project / Panel

Unified attachment model

Audit Fields

CreatedBy, UpdatedBy, timestamps, soft delete via IsActive

🗃 Database Schema Overview
Core Tables
Table	Purpose
UserTable	Maintains users and credentials
ProjectTable	Stores project-level details
Task	Stores tasks under a project
TaskDiscussion	Discussion threads for tasks
TaskPanel	Panels to group tasks
TaskPanelMapping	Maps tasks to panels
GuestsOfTaskPanel	Guest users for panels
TaskPanelInvitation	Invitation for panel access
AttachmentTable	File attachment metadata
Log (optional)	Activity logging/events
📦 Entity Highlights
TaskPanel

Used for grouping & sharing tasks between users.

TaskPanel
├─ ID
├─ TaskPanelName
├─ OwnerID
├─ CreatedBy / UpdatedBy
├─ CreatedDate / UpdatedDate
└─ IsActive

TaskPanelInvitation

Tracks sharing invites.

Status values:

Sent

In-Progress

Accepted

🛠 Tech Stack
Layer	Tech
Backend	ASP.NET Core Web API
Database	SQL Server
Language	C#
Auth	(Planned: JWT)
Deployment	TBD
🔄 Workflow Example

User creates a Project

User creates Tasks under Project

User groups tasks into a Task Panel

Panel owner invites collaborators

Collaborators join & discuss tasks

Attachments added for context

📈 Possible Use Cases

✔ Team collaboration
✔ Software project tracking
✔ Shared Kanban boards
✔ Research or student task tracking
✔ Task communication & documentation

🧱 ERD (Entity Relationship Diagram)

(Coming Soon — can auto-generate if you want)

🔧 Setup Instructions

(Adjust these according to your actual project)

Prerequisites

.NET SDK 8+ (or your version)

SQL Server local/remote

Visual Studio / VS Code

Setup
git clone <repo-url>
cd project-folder
dotnet restore
dotnet build
dotnet run


Configure DB connection in:

appsettings.json


Apply migrations / SQL schema creation.

🛣 Future Enhancements (Planned)

JWT Authentication

Role-based permissions

Real-time updates w/ SignalR

Notification system

Kanban UI Web App

Mobile-friendly UI

Activity Log Tracking

Multi-tenant Support

🤝 Contribution

Contributions are welcome — feel free to open issues or submit PRs.
