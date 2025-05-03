# 📘 CodeFirstAPI

Una API RESTful construida con ASP.NET Core y Entity Framework Core usando el enfoque **Code First**, conectada a **PostgreSQL**.

## 🚀 Características

- CRUD básico para el modelo `Post`
- Uso de Entity Framework Core con migraciones
- Base de datos PostgreSQL
- Documentación interactiva con Swagger
- Estilo minimalista usando controladores clásicos

---

## 📦 Requisitos

- [.NET 7 o 8 SDK](https://dotnet.microsoft.com/)
- PostgreSQL (ej. local: `localhost:5432`)
- Herramienta EF Core:

```bash
dotnet tool install --global dotnet-ef
```

---

## ⚙️ Configuración

### 1. Clona el repositorio

```bash
git clone https://github.com/tu-usuario/CodeFirstAPI.git
cd CodeFirstAPI
```

### 2. Configura la cadena de conexión

Edita `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=BlogDb;Username=postgres;Password=tu_contraseña"
}
```

### 3. Ejecuta las migraciones

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🧪 Ejecutar el proyecto

```bash
dotnet run
```

Abre en tu navegador:

👉 [http://localhost:5010/swagger](http://localhost:5010/swagger)

---

## 📚 Endpoints disponibles

| Método | Ruta          | Descripción                |
|--------|---------------|----------------------------|
| GET    | `/api/posts`  | Lista todos los posts      |
| POST   | `/api/posts`  | Crea un nuevo post         |

---

## 📂 Estructura del proyecto

```
CodeFirstAPI/
├── Controllers/
│   └── PostController.cs
├── Models/
│   └── Post.cs
├── Data/
│   └── AppDbContext.cs
├── Program.cs
└── appsettings.json
```

---

## 📄 Modelo `Post`

```csharp
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

---

## ✅ To Do

- [ ] PUT /api/posts/{id}
- [ ] DELETE /api/posts/{id}
- [ ] Autenticación con JWT
- [ ] Dockerfile para despliegue
