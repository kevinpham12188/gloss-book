# GlossBook

A nail salon booking and management platform built as a full microservices study project to demonstrate real-world backend engineering

## What it does

GlossBook allows salon owners to manage bookings, staff schedules, and inventory. Technicians can view their daily schedule and log product usage. Clients can book appointments online and receive automated reminders.

## Archirtecture

Six independent microservices communicating via HTTP and async messaging:

| Service | Responsibility |
|---|---|
| Booking | Appointments, availability, scheduling rules |
| Identity | Authentication, JWT, user profiles |
| Catalog | Services offered, pricing, categories |
| Inventory | Products, stock levels, depletion tracking |
| Payments | Deposits, charges, refunds |
| Notification | Email, push, and in-app alerts |

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# / .NET 10 |
| Databases | PostgreSQL (one per service) |
| Caching | Redis |
| Messaging | RabbitMQ |
| API Gateway | YARP |
| ORM | Entity Framework Core |
| Logging | Serilog + OpenTelemetry |
| Resilience | Polly |
| Testing | xUnit + Testcontainers + Moq |
| DevOps | Docker · Docker Compose · GitHub Actions |

## Running locally
```bash
docker-compose up
```

All six services, databases, Redis, and RabbitMQ start with one command

## Project status

## Build Status

### Phase 1 — Schema Design
- [x] Schema design — all 6 services

### Phase 2 — Environment Setup
- [x] macOS + Homebrew + Git + .NET 10 + Docker Desktop + VS Code + DBeaver

### Phase 3 — Booking Service
- [x] Project scaffold
- [x] Docker PostgreSQL container (port 5433)
- [x] Raw SQL migrations — 4 tables (appointments, staff_schedules, staff_breaks, staff_schedule_overrides)
- [x] EF Core packages installed (v10.0.5)
- [x] Entity models — Appointment, StaffSchedule, StaffBreak, StaffScheduleOverride
- [ ] BookingDbContext
- [ ] Connection string + Program.cs wiring
- [ ] POST /appointments endpoint
- [ ] Validation + global exception handling
- [ ] Unit tests — xUnit

### Phase 4 — Identity Service
- [ ] JWT auth

### Phase 5 — API Gateway
- [ ] YARP

### Phase 6 — Catalog + Inventory Services

### Phase 7 — Payments Service

### Phase 8 — Notification Service + RabbitMQ

### Phase 9 — Redis

### Phase 10 — Observability — Serilog + OpenTelemetry

### Phase 11 — Testing — xUnit + Testcontainers

### Phase 12 — CI/CD — GitHub Actions