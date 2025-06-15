# microservices-booking-platform
Plataforma de reservas distribuida desarrollada en .NET 9 con arquitectura de microservicios, autenticación JWT, mensajería con RabbitMQ, cache con Redis, CI/CD y monitoreo con Prometheus y Grafana.
# Microservices Booking Platform

Proyecto de referencia para construir una plataforma de reservas distribuida usando microservicios en .NET 9.

## 🧩 Tecnologías utilizadas

- .NET 9 Web API
- MySQL + EF Core (Pomelo)
- JWT Authentication
- RabbitMQ para mensajería
- Redis para caching
- Docker + Docker Compose
- Clean Architecture + SOLID + TDD
- CI/CD con GitHub Actions
- Prometheus + Grafana para monitoreo

## 📦 Microservicios

- `AuthService`: Registro, login, JWT, gestión de usuarios
- `BookingService`: Gestión de reservas (en desarrollo)
- `InventoryService`: Inventario y disponibilidad (en desarrollo)

## 🚀 Cómo ejecutar (temporal)

```bash
# Construcción y despliegue (por definir)
docker-compose up --build
