# MoneyFlow API

MoneyFlow API is the backend service for the **MoneyFlow Personal Finance Management System**.

It provides APIs to manage **accounts, categories, transactions, transfers, and financial summaries**.

The API follows a **clean layered architecture** and uses **SQL Server stored procedures with Dapper** for efficient database access.

---

# 🚀 Tech Stack

### Backend
- .NET 8
- ASP.NET Core Web API
- Dapper (Lightweight ORM)

### Database
- SQL Server
- Stored Procedures

### Tools
- Swagger (API documentation)

---

# 📌 Features

### Accounts
- Create and manage financial accounts
- Supports Cash, Bank, and Fixed Deposit accounts
- Tracks account balances

### Categories
- Manage income and expense categories
- System categories used internally (e.g. transfers)

### Transactions
- Add, edit, and delete transactions
- Handles income and expense operations
- Updates account balance automatically

### Transfers
- Transfer funds between accounts
- Implemented using **double-entry transaction logic**
- Each transfer creates two linked transactions
- Uses `TransferGroupId` to connect related entries

### Dashboard
- Total balance calculation
- Monthly income summary
- Monthly expense summary
- Net cash flow calculation
- Recent transactions data

---

# 🏗 Architecture

The API follows a **layered architecture**:

Responsibilities:

| Layer | Responsibility |
|------|---------------|
| Controllers | Handle HTTP requests and responses |
| Services | Business logic |
| Repositories | Data access using Dapper |
| Database | Stored procedures for financial operations |

---

## 📂 Project Structure

```text
├── Controllers
├── Models
├── Services
│   ├── Interfaces
│   └── Implementations
├── Repositories
│   ├── Interfaces
│   └── Implementations
└── Program.cs
```

---

# ⚙️ Setup Instructions

### Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio / VS Code

---

### Run the API

```bash
dotnet restore
dotnet build
dotnet run
```
---

## 📈 Project Status

### Phase 1 – Core Financial System (In Progress)

| Module | Status | Description |
|------|------|-------------|
| Accounts | ✅ Completed | Create and manage financial accounts with balance tracking |
| Categories | ✅ Completed | Manage income and expense categories |
| Transactions | ✅ Completed | Add, edit, delete transactions with automatic balance updates |
| Transfers | ✅ Completed | Transfer funds between accounts using double-entry transaction logic |
| Dashboard | ✅ Completed | Financial summary endpoints for balance, income, expense, and net flow |
| Budgets | 🚧 In Progress | Monthly budget tracking and spending limits |
| Installments (EMI) | 📌 Planned | Track installment payments and recurring obligations |
| Reports | 📌 Planned | Financial reports and analytics endpoints |

---

### Current Capabilities

The API currently supports:

- Account management
- Category management
- Transaction processing
- Account-to-account transfers
- Automatic balance calculation
- Dashboard financial summaries
- Stored procedure driven database operations

---

### Upcoming Improvements

Planned enhancements include:

- Budget management system
- Installment / EMI tracking
- Financial reports and analytics
- Performance improvements and additional validations

---

👨‍💻 Author : Anish Patel
