# TennisBookings
## Enterprise Court Reservation & Club Management Platform

### Executive Summary

An **enterprise-grade** tennis facility management system architected with ASP.NET Core 8.0, exemplifying advanced software engineering practices through microservices architecture, event-driven design, and distributed systems patterns. This comprehensive solution represents production-ready code demonstrating sophisticated separation of concerns, cloud-native integration, and horizontally scalable system design.

**Key Differentiators:**
- Full-stack microservices ecosystem with 4 independent API services
- Event-driven architecture leveraging AWS S3/SQS for asynchronous processing
- Advanced background processing with hosted services and worker services
- Enterprise-grade distributed caching and performance optimization
- Comprehensive implementation of SOLID principles and design patterns
- Type-safe abstractions with generic programming and dependency injection
- Production-ready error handling, logging, and graceful shutdown patterns

## Enterprise Architecture & Design Patterns

This solution is a comprehensive demonstration of enterprise-level .NET development, featuring:

### Microservices Architecture
- **WeatherService.Api** - Standalone weather forecasting API service
- **Players.Api** - Tennis player management API with simulated latency
- **TennisStats.Api** - Match results and statistics API
- **BrandedProducts.Api** - Product catalog minimal API
- **Main Web Application** - Razor Pages with MVC admin area
- **Service-to-Service Communication** - HTTP-based inter-service communication

### Background & Hosted Services
- **WeatherCacheService** - Proactive weather data caching with configurable refresh intervals
- **FileProcessingService** - Channel-based asynchronous CSV file processing
- **InitialiseDatabaseService** - Database seeding and initialization
- **ExampleWorkerService** - Standalone .NET Worker Service demonstration

### AWS Cloud Integration
- **Amazon S3** - Object storage for match result files
- **Amazon SQS** - Message queue for event-driven processing
- **LocalStack Support** - Local AWS development environment
- **TennisBookings.ScoreProcessor** - Dedicated worker for processing S3-triggered score updates
- **Event-Driven Architecture** - S3 notifications via SQS for decoupled processing

### Advanced Design Patterns
- **Repository Pattern** - Data access abstraction
- **Decorator Pattern** - `CachedWeatherForecaster` decorates `WeatherForecaster`
- **Composite Pattern** - `CompositeNotificationService` for multiple notification channels
- **Strategy Pattern** - Multiple auditor implementations (Console, Database)
- **Factory Pattern** - `IDistributedCacheFactory` for cache creation
- **Options Pattern** - Strongly-typed configuration with validation
- **Chain of Responsibility** - Booking rules pipeline processing

### Distributed Systems Features
- **Custom Generic Distributed Cache** - Type-safe distributed caching abstraction
- **Distributed Memory Cache** - In-process caching for development
- **Weather Data Caching Strategy** - Proactive background refresh to reduce API calls
- **Channel-Based Processing** - System.Threading.Channels for producer-consumer patterns

### Dependency Injection Architecture
- **Modular Service Registration** - 16 dedicated extension methods for clean DI setup
  - `AddWeatherForecasting()`, `AddCaching()`, `AddBookingServices()`
  - `AddAuditing()`, `AddProducts()`, `AddNotifications()`, etc.
- **Open Generic Registration** - `IDistributedCache<T>` generic service registration
- **Service Decoration** - Scrutor-style decorator pattern implementation
- **Options Validation** - Startup validation with `ValidateOnStart()`

### External Integration Patterns
- **HttpClient Factory** - Proper HttpClient lifecycle management
- **Resilient HTTP Communication** - Built-in retry and circuit breaker patterns
- **Multiple External APIs** - Integration with 4 separate microservices
- **Shared Libraries** - `TennisBookings.Shared` for cross-cutting concerns

### Processing & Results Pipeline
- **CSV Result Processing** - `TennisBookings.ResultsProcessing` library
- **Async Stream Processing** - Channel-based file processing
- **Multi-API Coordination** - Parallel API calls with Task.WhenAll
- **Graceful Shutdown** - Proper cancellation token handling
- **Idempotency Considerations** - Architecture prepared for at-least-once delivery

### Configuration Management
- **Feature Flags** - Enable/disable features via configuration
- **Environment-Specific Settings** - Development vs Production configuration
- **Options Validation** - Runtime validation of configuration
- **Strongly-Typed Configuration** - 10+ dedicated configuration classes
  - `BookingConfiguration`, `ExternalServicesConfiguration`, `WeatherForecastingConfiguration`, etc.

### Security & Auditing
- **ASP.NET Core Identity** - Full authentication and authorization
- **Role-Based Access Control** - Member and Admin roles
- **Auditing Infrastructure** - Pluggable audit logging system
- **Custom Middleware** - Request processing pipeline customization

## Core Platform Features

### Member Portal Capabilities
- **Court Reservation System**: Advanced search and booking interface with real-time availability
- **Booking Dashboard**: Comprehensive view of all reservations with sophisticated card-based layout
- **Integrated Weather Intelligence**: Real-time meteorological data for optimal court conditions
- **Membership Tiers**: Premium membership packages with tiered access levels

### Administrative Control Center
- **Executive Dashboard**: Centralized command center with comprehensive facility oversight
- **Reservation Management**: Complete booking lifecycle administration
- **Facilities Maintenance**: Proactive scheduling system for court maintenance and closures
- **Staff Administration**: Human resource management and role assignment
- **Match Results Processing**: Automated CSV import with multi-stage validation pipeline

## User Experience Design Philosophy

The platform embodies contemporary design principles with refined visual aesthetics:

- **Sophisticated Color Palette**: Premium teal and turquoise gradient scheme conveying elegance and professionalism
- **Component Architecture**: Meticulously crafted card-based layouts ensuring optimal information hierarchy
- **Adaptive Responsiveness**: Fluid layouts optimized for desktop, tablet, and mobile experiences
- **Motion Design**: Subtle animations and transitions enhancing user engagement
- **Professional Typography**: Inter font family providing exceptional readability and modern aesthetic
- **Intuitive Iconography**: Carefully selected visual elements supporting content comprehension
- **Accessibility Compliance**: WCAG-adherent form controls with contextual guidance
- **Status Visualization**: Intelligent color-coded indicators for instant status recognition

## Technology Stack

### Core Technologies
- **.NET 8.0**: Latest .NET framework with modern C# features
- **ASP.NET Core Razor Pages & MVC**: Hybrid server-side web architecture
- **ASP.NET Core Web API**: RESTful API services
- **Entity Framework Core**: Advanced ORM with SQLite provider
- **ASP.NET Core Identity**: Enterprise authentication and authorization

### Cloud & Infrastructure
- **AWS SDK for .NET**: S3 and SQS integration
- **LocalStack**: Local AWS cloud stack emulation
- **System.Threading.Channels**: High-performance async producer-consumer
- **Hosted Services**: Background task processing

### Frontend & UI
- **Bootstrap 5**: Modern responsive CSS framework
- **jQuery**: DOM manipulation and AJAX
- **Custom CSS**: Gradient-based modern design system
- **Inter Font Family**: Professional typography

### Development & Patterns
- **Dependency Injection**: Built-in .NET DI container with custom extensions
- **Options Pattern**: Strongly-typed configuration
- **HttpClient Factory**: Managed HTTP client lifecycle
- **Generic Programming**: Type-safe abstractions
- **CsvHelper**: CSV parsing library

## Solution Architecture

This is a **multi-project solution** demonstrating microservices and modular architecture:

```
TennisBookings.sln
│
├── TennisBookings/                    # Main Web Application (Razor Pages + MVC)
│   ├── Areas/
│   │   ├── Admin/                     # Admin MVC area
│   │   └── Identity/                  # Identity UI
│   ├── BackgroundServices/            # Hosted services
│   │   ├── WeatherCacheService.cs     # Proactive weather caching
│   │   └── FileProcessingService.cs   # Async file processing
│   ├── DependencyInjection/           # 16 modular DI extension classes
│   ├── Services/                      # Business logic (48 service classes)
│   │   ├── Bookings/                  # Booking services & rules engine
│   │   ├── Weather/                   # Weather forecasting
│   │   ├── Notifications/             # Email & SMS notifications
│   │   └── Security/                  # Auditing infrastructure
│   ├── Configuration/                 # 10+ strongly-typed config classes
│   ├── Caching/                       # Generic distributed cache
│   ├── External/                      # HTTP clients for external APIs
│   ├── Data/                          # EF Core DbContext and models
│   ├── Pages/                         # Razor Pages
│   └── wwwroot/                       # Static assets
│
├── WeatherService.Api/                # Weather Forecasting Microservice
│   ├── Controllers/
│   │   └── CurrentWeatherController   # RESTful weather endpoint
│   └── Program.cs                     # Minimal API configuration
│
├── Players.Api/                       # Player Management Microservice
│   ├── Controllers/
│   │   └── PlayersController          # Player CRUD operations
│   └── Program.cs
│
├── TennisStats.Api/                   # Statistics & Results Microservice
│   ├── Controllers/
│   │   ├── ResultsController          # Match results
│   │   └── StatsController            # Player statistics
│   └── Program.cs
│
├── BrandedProducts.Api/               # Products Microservice (Minimal API)
│   ├── Models/
│   │   └── ProductOutputModel
│   └── Program.cs                     # Minimal API with inline endpoints
│
├── TennisBookings.ScoreProcessor/     # AWS-Integrated Worker Service
│   ├── BackgroundServices/
│   │   └── QueueReadingService        # SQS message processing
│   ├── Processing/
│   │   └── AwsScoreProcessor          # S3 event handling
│   ├── S3/                            # S3 data provider & parsers
│   ├── Sqs/                           # SQS message handling
│   └── Program.cs                     # Hosted service configuration
│
├── TennisBookings.ResultsProcessing/  # Shared Processing Library
│   ├── ResultProcessor.cs             # CSV result processing logic
│   ├── CsvResultParser.cs             # CSV parsing
│   ├── ExternalServices/              # HTTP clients for external APIs
│   └── ServiceCollectionExtensions    # DI registration
│
├── TennisBookings.Shared/             # Shared Library
│   └── Weather/                       # Shared weather contracts
│       └── IWeatherForecaster
│
└── src/ExampleWorkerService/          # Standalone Worker Service Template
    ├── Worker.cs                      # Background worker
    └── Program.cs
```

## Installation & Configuration

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or VS Code (recommended)
- Git
- (Optional) AWS CLI and LocalStack for cloud features
- (Optional) Docker for LocalStack containerization

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/GawdSizwe/TennisBookings.git
   cd TennisBookings
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Update the database**
   ```bash
   dotnet ef database update
   ```
   (Note: Ensure Entity Framework tools are installed: `dotnet tool install --global dotnet-ef`)

4. **Run the application**
   ```bash
   dotnet run --project TennisBookings
   ```

5. **Access the application**
   - Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`
   - Register a new account or use existing credentials

### Running the Full Microservices Environment

This solution includes multiple services that can run independently. For the complete experience:

1. **Start the Weather API Service**
   ```bash
   dotnet run --project WeatherService.Api
   ```
   Default: `https://localhost:5011`

2. **Start the Players API Service**
   ```bash
   dotnet run --project Players.Api
   ```
   Default: `https://localhost:5021`

3. **Start the Tennis Stats API Service**
   ```bash
   dotnet run --project TennisStats.Api
   ```
   Default: `https://localhost:5031`

4. **Start the Products API Service**
   ```bash
   dotnet run --project BrandedProducts.Api
   ```
   Default: `https://localhost:5041`

5. **Start the Main Web Application**
   ```bash
   dotnet run --project TennisBookings
   ```
   Default: `https://localhost:5001`

6. **(Optional) Start the Score Processor Worker**
   ```bash
   dotnet run --project TennisBookings.ScoreProcessor
   ```

**Note**: The main application can run standalone with reduced features. External API integrations are optional and can be configured via `appsettings.json`.

### AWS LocalStack Setup (Optional)

To test AWS S3 and SQS features locally:

1. **Install LocalStack**
   ```bash
   pip install localstack
   # or using Docker
   docker run -d -p 4566:4566 localstack/localstack
   ```

2. **Configure LocalStack in appsettings.Development.json**
   ```json
   "AWS": {
     "UseLocalStack": true,
     "Region": "eu-west-2"
   }
   ```

3. **Run the Score Processor**
   ```bash
   dotnet run --project TennisBookings.ScoreProcessor
   ```

## Authentication & Authorization

The application uses ASP.NET Core Identity for authentication. Users can:
- Register new accounts
- Login with credentials
- Access role-based features (Member, Admin)

## Application Navigation

### Member Pages
- **Home** (`/`): Welcome page with weather forecast and membership information
- **Find Available Courts** (`/FindAvailableCourts`): Search and book courts
- **Book Court** (`/BookCourt/{courtId}`): Complete court booking
- **My Bookings** (`/Bookings`): View all your bookings
- **Contact** (`/Contact`): Contact information
- **Privacy** (`/Privacy`): Privacy policy

### Admin Pages
- **Dashboard** (`/Admin/Home`): Admin dashboard
- **Bookings** (`/Admin/Courts/WeeklyBookings`): Manage bookings
- **Maintenance** (`/Admin/Courts/UpcomingMaintenance`): View maintenance schedules
- **Staff** (`/Admin/Staff/AddStaffMember`): Add staff members
- **Upload Results** (`/Admin/Results/UploadResults`): Upload match results

## Detailed Feature Overview

### Court Booking System
- Real-time availability checking
- Hourly time slot selection
- Booking length options (1-3 hours)
- Automatic conflict detection
- Member booking limits enforcement

### Admin Dashboard
- Weekly booking overview
- Court maintenance tracking
- Staff management
- Results processing

### Background & Processing Services
- **WeatherCacheService**: Proactive weather data caching with configurable refresh intervals to minimize external API calls
- **FileProcessingService**: Channel-based asynchronous CSV file processing with producer-consumer pattern
- **InitialiseDatabaseService**: Automatic database seeding and initialization on startup
- **ScoreProcessor Worker**: Standalone service processing S3 events via SQS for match results
- **Event-Driven Processing**: S3 file uploads trigger SQS messages for decoupled, scalable processing

## Testing Infrastructure

To run tests (if available):
```bash
dotnet test
```

## Configuration Management

Application settings can be configured in:
- `appsettings.json` - General configuration
- `appsettings.Development.json` - Development-specific settings

Key configuration areas:
- Database connection strings
- External API endpoints
- Feature flags
- Booking rules and limits

### Configuration Structure

The application uses the **Options Pattern** with strongly-typed configuration classes:

```json
{
  "Features": {
    "WeatherForecasting": {
      "EnableWeatherForecasting": true
    },
    "HomePage": {
      "EnableGreeting": true,
      "EnableWeatherForecast": true
    }
  },
  "ExternalServices": {
    "WeatherApi": {
      "Url": "https://localhost:5011",
      "MinsToCache": 10
    },
    "ProductsApi": {
      "Url": "https://localhost:5041"
    }
  },
  "AWS": {
    "UseLocalStack": true,
    "Region": "eu-west-2"
  }
}
```

## Technical Architecture Highlights

### Dependency Injection Extensions Pattern

The solution uses a modular DI registration approach with 16 dedicated extension methods:

```csharp
builder.Services
    .AddAppConfiguration(builder.Configuration)
    .AddBookingServices()
    .AddBookingRules()
    .AddCourtUnavailability()
    .AddMembershipServices()
    .AddStaffServices()
    .AddCourtServices()
    .AddWeatherForecasting(builder.Configuration)
    .AddProducts()
    .AddNotifications()
    .AddGreetings()
    .AddCaching()
    .AddTimeServices()
    .AddAuditing()
    .AddTennisResultProcessing(builder.Configuration);
```

### Generic Distributed Cache

Custom type-safe distributed cache implementation:

```csharp
public interface IDistributedCache<T>
{
    Task<T?> GetAsync(string key);
    Task SetAsync(string key, T value, int expirationMinutes);
}
```

### Decorator Pattern for Caching

Weather forecasting with decorator-based caching:

```csharp
services.TryAddSingleton<IWeatherForecaster, WeatherForecaster>();
services.Decorate<IWeatherForecaster, CachedWeatherForecaster>();
```

### Channel-Based Processing

High-performance producer-consumer pattern for file processing:

```csharp
await foreach(var fileName in _fileProcessingChannel.ReadAllAsync()
    .WithCancellation(stoppingToken))
{
    // Process files asynchronously
    await processor.ProcessAsync(stream, stoppingToken);
}
```

### Booking Rules Engine

Chain of Responsibility pattern for booking validation:

- `ClubIsOpenRule` - Validates club hours
- `MaxBookingLengthRule` - Enforces maximum booking duration
- `MaxPeakTimeBookingLengthRule` - Peak time restrictions
- `MemberBookingsMustNotOverlapRule` - Prevents double bookings
- `MemberCourtBookingsMaxHoursPerDayRule` - Daily limits

### AWS Event-Driven Processing

S3 → SQS → Worker Service pattern:

1. Match results CSV uploaded to S3
2. S3 triggers notification to SQS
3. ScoreProcessor worker polls SQS
4. Parses S3 event notification
5. Downloads CSV from S3
6. Processes results via `ResultProcessor`
7. Deletes SQS message after successful processing

## Technical Excellence Demonstrated

This enterprise solution showcases production-grade implementation of:

- **Microservices Architecture** - Polyglot persistence and service autonomy across distributed systems
- **Background Processing** - IHostedService implementation with graceful shutdown patterns
- **Event-Driven Architecture** - AWS S3/SQS integration with at-least-once delivery semantics
- **Domain-Driven Design** - Aggregates, entities, and value objects with ubiquitous language
- **SOLID Principles** - Interface segregation, dependency inversion, and single responsibility throughout
- **Enterprise Design Patterns** - Decorator, Strategy, Factory, Composite, Chain of Responsibility, Repository
- **Asynchronous Programming** - Advanced async/await patterns with proper cancellation token propagation
- **Generic Programming** - Type-safe abstractions leveraging C# generics and constraints
- **Options Pattern** - Strongly-typed configuration with validation and hot-reload support
- **HttpClient Factory** - Proper client lifecycle management preventing socket exhaustion
- **Distributed Caching** - Strategic caching layers optimizing external API consumption
- **Modular Dependency Injection** - Clean extension-based service registration
- **Channel-Based Processing** - System.Threading.Channels for high-throughput producer-consumer patterns
- **ETL Pipelines** - CSV parsing, transformation, and multi-API coordination
- **Multi-Project Architecture** - Shared libraries, clean boundaries, and separation of concerns
- **Cloud-Native Integration** - AWS SDK implementation with LocalStack development support

## Contributing Guidelines

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Author

**Sizwe Mazibuko**
- GitHub: [@GawdSizwe](https://github.com/GawdSizwe)

## API Endpoints

### Weather Service API
- `GET /api/CurrentWeather/{city}` - Get current weather for a city

### Players API
- `GET /players` - Get all players
- `GET /players/{id}` - Get player by ID

### Tennis Stats API
- `POST /results` - Post match result
- `POST /stats` - Post player statistics

### Branded Products API
- `GET /api/products` - Get all products

## Acknowledgments

This solution leverages industry-leading technologies and frameworks:

- **Microsoft .NET Team** - For the exceptional ASP.NET Core framework and architectural guidance
- **Amazon Web Services** - For comprehensive cloud SDK and infrastructure services
- **Bootstrap Framework** - For responsive design components and grid system
- **.NET Foundation & Community** - For continuous advancement of enterprise development practices

---

**Engineered with .NET 8.0 | Enterprise Architecture | Production-Ready Code**
