A) Estilo y convenciones (C#)

Nullable Reference Types habilitado (<Nullable>enable</Nullable>) y tratar warnings como guía (idealmente no ignorarlos).

Usar record/record struct para DTOs inmutables cuando aplique (o sealed class si necesitas mutabilidad), pero ser consistente:

DTOs de API: sealed class simple suele ser suficiente.

Preferir var cuando el tipo es obvio en el lado derecho; usar tipo explícito cuando mejora legibilidad.

async/await siempre para I/O (DB, HTTP). No usar .Result / .Wait().

No usar #region salvo casos muy justificados (tienden a ocultar diseño pobre).

Usar DateTimeOffset para fechas que representen instantes (auditoría/creación), y DateTime solo si es “fecha civil” (nacimiento, etc.). (Esto reduce bugs de zona horaria.)



B) API / diseño de endpoints

Controllers delgados: no meter lógica de negocio en controllers; llamar a servicios (Application layer).

Códigos HTTP consistentes:

200 OK para GET

404 NotFound si no existe

400 BadRequest si validación falla

500 solo para errores no controlados (con middleware)

Versionado: aunque no lo uses ya, deja preparado prefijo api/ (ya lo tienes) y una estrategia futura (/api/v1/... o header). Define esto en un comentario/decisión.

No exponer entidades EF directamente en responses. Siempre DTOs (Contracts).



C) Datos / EF Core

AsNoTracking() por defecto en lecturas (listados/detalles) salvo que realmente vayas a modificar.

Proyección a DTO en la query (Select) para evitar traer entidades completas.

Paginación y filtros desde el inicio en listados que puedan crecer (aunque sea simple):

?page=1\&pageSize=50 con límites (ej. max 200)

Evitar lazy loading en EF Core (no habilitar proxies). Preferir Include o proyección.

Migrations: si el proyecto es database-first y la DB ya existe, documentar que:

scaffold es fuente de entidades

migrations solo se usan si se agregan tablas nuevas (si aplica)

SPs: encapsular llamadas a stored procedures en una clase/repo dedicado, no dentro del controller.



D) Errores, logging y observabilidad

Exception Handling global (middleware) + respuestas consistentes (ProblemDetails):

AddProblemDetails() (en .NET 8) y un handler global

Logging estructurado: usar ILogger<T>; no Console.WriteLine.

No loggear secretos (connection strings, passwords, tokens).

Correlation/Trace Id en logs (si usas ProblemDetails, incluir traceId).



E) Seguridad (aunque sea después)

Nunca construir SQL concatenando strings (aunque uses FromSqlRaw, usar parámetros).

CORS: habilitar

Validación de entrada:

DataAnnotations o FluentValidation (si decides usarlo) de forma consistente.

No devolver image/binarios en DTOs de listados: endpoints separados con Content-Type correcto.



F) Pruebas y calidad

Tests mínimos por capa (aunque sean pocos al inicio):

API: test de integración de 1–2 endpoints (si te animas)

Application: unit tests para reglas (en v2)

Formatting/Analyzers:

.editorconfig en la raíz para estilo uniforme

dotnet format opcional

CI básico (cuando puedas):

build + test en GitHub Actions



H) Reglas “anti-regresión” (muy importante en migración)

Cambios pequeños y reversibles: cada commit/PR debe ser pequeño y con objetivo claro.

No renombrar masivamente clases/propiedades hasta que el MVP esté estable (reduce ruido).

Cuando edites código existente:

lee primero (no sobrescribir)

conservar compatibilidad

agregar pruebas/validación si el cambio es delicado


Reglas recomendadas (versión “best practices”)
Usar C# y .NET modernos

Usar .NET 8 y características modernas de C# (por ejemplo: file-scoped namespaces, pattern matching, switch expressions, using globales cuando convenga).
Preferir APIs actuales del framework y evitar patrones heredados del .NET Framework (p.ej. WebClient, BinaryFormatter, HttpWebRequest).
Convenciones de nombres (C# estándar)

Clases, métodos, propiedades, DTOs: PascalCase.
Variables locales y parámetros: camelCase.
Campos privados (fields): _camelCase (guion bajo solo en campos privados).
Evitar guion bajo en parámetros (no es convención usual y dificulta lectura).
Ejemplo recomendado:
C#
private readonly IClienteRepository _clienteRepository;

public ClienteService(IClienteRepository clienteRepository)
{
    _clienteRepository = clienteRepository;
}
Entidades EF Core: propiedades en PascalCase; mapeo a BD en el DbContext

Las entidades scaffolded vendrán con propiedades en PascalCase (correcto en C#).
No renombrar columnas/propiedades solo por estilo si eso rompe el scaffold o complica diffs.
Cuando haya discrepancias con la BD (nombres raros), resolver vía mapeo Fluent (ToTable, HasColumnName) y no con hacks.
Dependencias: evitar librerías obsoletas y minimizar dependencias

No introducir paquetes desactualizados o sin mantenimiento.
Preferir librerías “first-party” de Microsoft cuando aplique (EF Core, logging, configuration, HttpClientFactory).
Agregar dependencias nuevas solo si hay justificación clara (y documentarla brevemente).
Comentarios y documentación: explicar el “por qué”, no lo obvio

Comentar decisiones, reglas de negocio, supuestos y puntos delicados (p.ej. “esta consulta replica vwClientes”).
Evitar comentarios redundantes (“incrementa i”).
Usar comentarios XML (///) en interfaces/servicios públicos cuando ayude al equipo.
Cambios en código existente: no romper, no sobreescribir

Antes de modificar un archivo existente, revisar el flujo completo y conservar comportamiento.
Cambios pequeños y localizados, con validación (build/tests/manual) antes de seguir.
Evitar refactors grandes mezclados con cambios funcionales (separarlos por commits/PRs).
Si un cambio puede tener impacto, agregar un test o al menos un caso de validación reproducible.

Async correcto
Para DB/HTTP usar async/await end-to-end; prohibido .Result/.Wait().
Manejo de errores consistente
En API usar ProblemDetails/middleware para errores no controlados; controllers devuelven 404/400 según corresponda.


