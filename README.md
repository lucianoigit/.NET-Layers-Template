# Plantilla Drugstore API - Arquitectura Limpia con .NET

Este proyecto es una plantilla base para el desarrollo de aplicaciones **Drugstore** utilizando **Clean Architecture** en .NET. Ofrece una base estructurada para construir aplicaciones robustas, escalables y mantenibles.

---

## Estructura del Proyecto

El proyecto sigue la arquitectura limpia con una estructura modular:

- **`Drugstore.Api`**: Capa de presentación. Contiene los controladores y la configuración de la API.
- **`Drugstore.App`**: Implementa los casos de uso y la lógica específica de la aplicación.
- **`Drugstore.Domain`**: Define el dominio del negocio, incluyendo entidades, agregados, value objects y reglas de negocio.
- **`Drugstore.Infrastructure`**: Maneja la persistencia, integraciones externas y otras configuraciones de infraestructura.

---

## Características Principales

1. **Arquitectura Limpia**
   - Separación clara de responsabilidades entre capas.
   - Bajo acoplamiento y alta cohesión.

2. **Plantilla Personalizable**
   - Fácil adaptación para proyectos Drugstore u otras soluciones similares.

3. **Integración con Herramientas Modernas**
   - Documentación automática con Swagger.
   - Validación robusta con FluentValidation.

---

## Instalación y Configuración

### Requisitos Previos

- **.NET 7 o superior**.
- Base de datos compatible (PostgreSQL, SQL Server, etc.).
- Herramienta CLI para migraciones (Ejemplo: `dotnet-ef`).

### Instrucciones

1. **Clonar el Repositorio**
   ```bash
   git clone https://github.com/lucianoigit/.NET-Layers-Template
   cd Drugstore
   ```

2. **Configurar la Base de Datos**
   - Actualiza el archivo `appsettings.json` en el proyecto `Drugstore.Api` con la cadena de conexión de tu base de datos.

3. **Ejecutar Migraciones**
   ```bash
   dotnet ef database update --project Drugstore.Infrastructure
   ```

4. **Ejecutar la Aplicación**
   ```bash
   dotnet run --project Drugstore.Api
   ```
   La API estará disponible en: `https://localhost:5001`

---

## Principios de Diseño

1. **Separación de Responsabilidades**
   - Cada capa tiene una responsabilidad única y bien definida.

2. **Inversión de Dependencias**
   - Uso de interfaces para desacoplar las dependencias entre capas.

3. **Diseño Modular**
   - Fácil extensión y modificación de los módulos existentes.

---

## Tecnologías Utilizadas

- **.NET 8**: Framework principal.
- **Entity Framework Core**: Manejo de base de datos.
- **FluentValidation**: Validación de modelos y comandos.
- **Swagger**: Generación automática de documentación.
- **Docker**: Contenedores para desarrollo y despliegue.

---


