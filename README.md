# MoneyFlow API

MoneyFlow API is the backend service for the **MoneyFlow Personal Finance Management System**.

It provides APIs to manage **accounts, categories, transactions, transfers, budgets, and financial summaries**.

The API follows a **clean layered architecture** (.NET 8 multi-project solution) and uses **SQL Server stored procedures with Dapper** for high-performance data access.

---

# 🚀 Tech Stack

### Backend
- .NET 8
- ASP.NET Core Web API
- Dapper (High-performance micro-ORM)

### Database
- SQL Server
- Parameterized Stored Procedures
- Relational integrity constraints and targeted non-clustered indexes

### Tools & Documentation
- Swagger / OpenAPI (API documentation & interactive test console)
- JWT Authentication & BCrypt Password Hashing

---

# 📌 Features

### Accounts
- Create, view, update, and manage financial accounts
- Supports Cash, Bank, and Fixed Deposit accounts
- Real-time balance recalculation and tracking

### Categories
- Manage income and expense categories
- Frequency categorization (`Monthly`, `Bimonthly`, `Quarterly`, `SixMonthly`, `Yearly`, `OneTime`) for automated budget planning
- System categories used internally (e.g. transfers)

### Transactions
- Add, edit, and delete transactions
- Handles income and expense operations
- Updates account balance automatically via database transactions
- Search, filter by category, account, and date range

### Transfers
- Transfer funds between accounts
- Implemented using **double-entry transaction logic**
- Each transfer creates two linked transactions
- Uses `TransferGroupId` to connect related entries atomically

### Budgets
- Category-level budget planning with spending limits
- Grouped budgeting aligned with category frequencies (`Monthly`, `Bimonthly`, `Quarterly`, `SixMonthly`, `Yearly`, `OneTime`)
- Period tracking (`PeriodMonth`, `PeriodYear`)
- Real-time spent calculations aggregated against transactions for the selected period
- Auto-generation of budgets copied from previous period budgets (`MF_Budgets_AutoGenerate`)
- Enforces unique constraint per user, category, and period (`UQ_MF_Budgets_Period`)

### Dashboard
- Total balance calculation across active accounts
- Monthly income and expense summaries
- Net cash flow calculation
- Recent transactions feed

---

# 🏗 Architecture

The API solution follows a **clean multi-project layered architecture**:

| Layer / Project | Responsibility |
|-----------------|----------------|
| `MONEY_FLOW_API` | Controllers, HTTP endpoints, routing, middleware, DI registration |
| `MONEY_FLOW_API.Model` | Domain entities, request DTOs, and view models |
| `MONEY_FLOW_API.IService` | Service interface contracts |
| `MONEY_FLOW_API.Service` | Business logic and validation |
| `MONEY_FLOW_API.IRepository` | Repository interface contracts |
| `MONEY_FLOW_API.Repository` | Data access layer using Dapper and stored procedures |
| Database | SQL Server stored procedures and relational tables |

---

## 📂 Project Structure

```text
moneyflow-api/
├── MONEY_FLOW_API/               # Web API Host & Controllers
│   ├── Controllers/
│   │   ├── Accounts/
│   │   ├── Categories/
│   │   ├── Setup/               # BudgetsController, etc.
│   │   ├── Transactions/
│   │   └── Dashboard/
│   ├── Extensions/              # Repository & Service DI Registrations
│   └── Program.cs
├── MONEY_FLOW_API.Model/         # Domain Models & DTOs
├── MONEY_FLOW_API.IService/      # Service Contracts
├── MONEY_FLOW_API.Service/       # Business Logic Implementations
├── MONEY_FLOW_API.IRepository/   # Repository Contracts
├── MONEY_FLOW_API.Repository/    # Dapper Stored Procedure Access
└── MONEY_FLOW_API.sln
```

# ⚙️ Setup Instructions

### Prerequisites
- .NET 8 SDK
- SQL Server (2019+)
- Visual Studio 2022 / VS Code

---

### Run the API

```bash
dotnet restore
dotnet build
dotnet run --project MONEY_FLOW_API
```

Swagger UI will be available at: `https://localhost:7196/swagger` (or configured launch URL).

---

## 📈 Project Status

### Phase 1 – Core Financial System

| Module | Status | Description |
|------|------|-------------|
| Accounts | ✅ Completed | Create and manage financial accounts with balance tracking |
| Categories | ✅ Completed | Manage income and expense categories with frequency settings |
| Transactions | ✅ Completed | Add, edit, delete transactions with automatic balance updates |
| Transfers | ✅ Completed | Transfer funds between accounts using double-entry transaction logic |
| Dashboard | ✅ Completed | Financial summary endpoints for balance, income, expense, and net flow |
| Budgets | ✅ Completed | Monthly/period budget limits, frequency grouping, auto-generation, spent tracking |
| Installments (EMI) | 📌 Planned (Next Phase) | Track installment payments and recurring obligations |
| Reports | 📌 Planned | Financial reports and analytics endpoints |

---

### Current Capabilities
The API currently supports:
- Full account lifecycle and balance tracking
- Income/expense categories with frequency configuration
- Real-time double-entry transaction and fund transfer processing
- Periodic budget limits, spent calculations, and auto-generation
- Executive dashboard metrics and financial statistics
- Stored procedure driven database operations with Dapper

---

### Next Phase: Installments (EMI) & Reports
Planned enhancements:
- Installment / EMI lifecycle tracking (Loan amount, interest, EMI schedules)
- Advanced financial analytics, breakdown reports, and data exports
- Visual trend metrics and forecasting

---

👨‍💻 Author : Anish Patel
