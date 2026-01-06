# Proyecto final API

Servicio Web REST desarrollado con **.NET 9** y **Entity Framework Core 9**, utilizando **PostgreSQL (Supabase)** como base de datos.

El proyecto aplica **arquitectura en capas**, **principios de Programación Orientada a Objetos (POO)**, **validaciones de datos** y **documentación interactiva con Swagger**.

---

## Arquitectura del Proyecto

El proyecto está organizado siguiendo una arquitectura en capas:

- **MyProject.Api**  
  Controladores, configuración de la API y middlewares.

- **MyProject.Application**  
  Lógica de negocio y DTOs.

- **MyProject.Domain**  
  Entidades del dominio e interfaces.

- **MyProject.Infrastructure**  
  DbContext, repositorios y acceso a datos con Entity Framework Core.

---

## Base de Datos

- **Motor:** PostgreSQL  
- **Proveedor:** Supabase  
- **ORM:** Entity Framework Core 9  

La base de datos se crea automáticamente desde el código utilizando **EF Core (Code First)**, sin necesidad de modificar manualmente la base de datos.

---

## Entidades del Dominio

El proyecto cuenta con las siguientes entidades:

- Category  
- Product  
- User  
- Order  
- OrderItem  
- Payment  

La entidad **Category** implementa un CRUD completo y se utiliza como ejemplo principal de funcionamiento.

---

## Endpoints disponibles (Category)

| Método | Endpoint |
|------|---------|
| GET | `/api/categories` |
| GET | `/api/categories/{id}` |
| POST | `/api/categories` |
| PUT | `/api/categories/{id}` |
| DELETE | `/api/categories/{id}` |

---

## Validaciones

Las validaciones se realizan mediante **DataAnnotations** en los DTOs, garantizando la integridad de los datos enviados a la API.

Ejemplos de validaciones:
- Campos obligatorios
- Longitud mínima y máxima
- Formatos válidos

---

## Documentación de la API

La API está documentada con **Swagger**, lo que permite visualizar y probar los endpoints fácilmente.

### URL de Swagger
```http
http://localhost:5093/swagger
```
---

## Cómo ejecutar el proyecto

### 1 Clonar el repositorio
```bash
git clone https://github.com/isrcastroes-oss/Proyecto-final
```

### 2️ Configurar la cadena de conexión
En el archivo appsettings.json:
```json
"ConnectionStrings": {
  "Default": "Host=TU_HOST;Port=5432;Database=postgres;Username=postgres;Password=TU_PASSWORD;SSL Mode=Require;Trust Server Certificate=true;"
}
```

### 3️ Ejecutar el proyecto
```bash
dotnet run --project MyProject.Api
```

## Uso
A continuación se muestran ejemplos básicos de uso de la API utilizando la entidad Category.

## Crear una categoría
Request:
```http
POST /api/categories
```
Content-Type: application/json

{
  "name": "Electrónica",
  "description": "Productos electrónicos"
}

Respuesta esperada:
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "name": "Electrónica",
  "description": "Productos electrónicos"
}

## Obtener todas las categorías
Request:
```http
GET /api/categories
```

Respuesta esperada:
[
  {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "name": "Electrónica",
    "description": "Productos electrónicos"
  }
]

## Obtener una categoría por ID
Request:
```http
GET /api/categories/{id}
```

Respuesta esperada:
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "name": "Electrónica",
  "description": "Productos electrónicos"
}

## Actualizar una categoría
Request:
```http
PUT /api/categories/{id}
```
Content-Type: application/json
{
  "name": "Electrónica y Tecnología",
  "description": "Productos electrónicos y tecnológicos"
}

Respuesta esperada:
204 No Content

## Eliminar una categoría
Request:
```http
DELETE /api/categories/{id}
```

Respuesta esperada:
204 No Content

## Pruebas
Los endpoints pueden probarse utilizando:
- Swagger
- Postman
- curl
