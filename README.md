# 🗂️ **Task Management System**

> **Collaborative task planning with task panels, discussions, sharing & attachments — built with ASP.NET Core & SQL Server**

---

## 📚 **Table of Contents**

- **Features**
- **Architecture Overview**
- **Database Schema**
- **Tech Stack**
- **Setup & Installation**
- **Roadmap**
- **License**

---

## 🚀 **Features**

- 🗃 **Project Management**
- 📌 **Task Assignment & Scheduling**
- 🎛 **Task Panels (Board / Kanban style)**
- 👥 **Guest & Sharing Support**
- 📨 **Invitation System**
- 💬 **Task Discussions**
- 📎 **Attachments for Tasks / Projects / Panels**
- 🕒 **Audit Fields & Soft Delete**

---

## 🧱 **Architecture Overview**
**Project → Tasks → Task Panels → Guests → Discussions → Attachments**

Supports both **individual** and **team collaboration**.

---

## 🗄️ **Database Schema Overview**

### 📍 **Main Entities**

| **Table** | **Purpose** |
|---|---|
| `UserTable` | Stores users & account info |
| `ProjectTable` | Stores project details |
| `Task` | Stores task details |
| `TaskDiscussion` | Comments / discussion per task |
| `TaskPanel` | Boards for organizing tasks |
| `TaskPanelMapping` | Maps tasks to task panels |
| `GuestsOfTaskPanel` | Panel collaborators |
| `TaskPanelInvitation` | Invitation workflow for access |
| `AttachmentTable` | File attachments metadata |

---

### 📁 **Attachment Types**

Supports attachments for:

- **Project**
- **Task**
- **TaskPanel**

---

## 🛠 **Tech Stack**

| **Layer** | **Technology** |
|---|---|
| Backend | **ASP.NET Core Web API** |
| Language | **C#** |
| Database | **SQL Server** |
| ORM | *(Optional: EF Core if used)* |
| Auth | *(Planned: JWT)* |
| UI | *(Planned: Kanban Web UI)* |

---

## 🔧 **Setup & Installation**

```bash
git clone <repo-url>
cd TaskManagement
dotnet restore
dotnet build
dotnet run

