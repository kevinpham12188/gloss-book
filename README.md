# GlossBook

A nail salon booking and management platform built as a full microservices study project to demonstrate real-world backend engineering

## What it does

GlossBook allows salon owners to manage bookings, staff schedules, and inventory. Technicians can view their daily schedule and log product usage. Clients can book appointments online and receive automated reminders.

## Archirecture

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

- [x] Schema design — all six services
- [ ] Booking Service — REST API
- [ ] Identity Service — JWT auth
- [ ] API Gateway — YARP
- [ ] Catalog + Inventory Services
- [ ] Payments Service
- [ ] Notification Service — async messaging
- [ ] Redis — caching + rate limiting
- [ ] Testing — xUnit + Testcontainers
- [ ] Observability — Serilog + OpenTelemetry
- [ ] CI/CD — GitHub Actions