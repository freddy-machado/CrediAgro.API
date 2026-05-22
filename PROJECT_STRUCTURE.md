# Estructura del proyecto: API

```
API/
├── src/
│   ├── CrediAgro.Api/
│   │   ├── Properties/
│   │   │   └── launchSettings.json
│   │   ├── appsettings.Development.json
│   │   ├── appsettings.json
│   │   ├── CrediAgro.Api.csproj
│   │   ├── CrediAgro.Api.http
│   │   └── Program.cs
│   ├── CrediAgro.Application/
│   │   ├── Clientes/
│   │   │   ├── Interfaces/
│   │   │   └── Services/
│   │   ├── Common/
│   │   ├── Creditos/
│   │   │   ├── Interfaces/
│   │   │   └── Services/
│   │   └── CrediAgro.Application.csproj
│   └── CrediAgro.Infrastructure/
│       ├── Clientes/
│       │   └── Queries/
│       ├── Common/
│       │   └── Sql/
│       ├── Creditos/
│       │   └── Queries/
│       ├── Persistence/
│       │   └── Models/
│       └── CrediAgro.Infrastructure.csproj
├── CREDIAGRO.Api.slnx
└── generate-project-structure.js
```

> Generado automáticamente por generate-project-structure.js