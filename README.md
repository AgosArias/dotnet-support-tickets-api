# Support Tickets API

API REST en ASP.NET Core / C# para la gestión de tickets de soporte: creación, asignación, seguimiento de estado y resolución.

## 🎯 Propósito

Permite a un equipo de soporte registrar tickets de clientes, asignarlos a agentes, y hacer seguimiento de su ciclo de vida (abierto → en progreso → resuelto).

## 🏗️ Arquitectura

<!-- TODO: completa esta sección mirando las carpetas dentro de src/ en el repo.
Ejemplo A (capas simples): Controllers → Services → Repositories → DbContext
Ejemplo B (Clean Architecture): Domain → Application → Infrastructure → API
-->

El proyecto está organizado en las siguientes capas:

- **[COMPLETAR]** — [qué hace esta capa]
- **[COMPLETAR]** — [qué hace esta capa]
- **[COMPLETAR]** — [qué hace esta capa]

### Decisión de arquitectura (ADR)

**¿Por qué esta estructura?**
[COMPLETAR: una o dos frases sobre por qué elegiste esta separación — ej. "separar la lógica de negocio del acceso a datos permite testear las reglas de asignación de tickets sin depender de la base de datos".]

## 🚀 Stack

- ASP.NET Core / C#
- Entity Framework Core (si aplica — confirmar)
- SQL Server / [tu base de datos real]

## 📋 Funcionalidades

- Creación y consulta de tickets
- Asignación a agentes de soporte
- Seguimiento y actualización de estado
- [Agregar cualquier otra funcionalidad relevante]

## ▶️ Cómo correrlo

```bash
git clone https://github.com/AgosArias/dotnet-support-tickets-api.git
cd dotnet-support-tickets-api
dotnet restore
dotnet build
dotnet run
```

---

📫 Contacto: [LinkedIn](https://www.linkedin.com/in/agosarias/) · agosarias99@gmail.com
