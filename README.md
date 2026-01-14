# TennisBookings - Modern Tennis Court Booking System

A comprehensive tennis court booking system built with ASP.NET Core, featuring a modern, clean UI/UX design. This application allows members to book courts, view their bookings, and provides administrators with tools to manage court schedules, maintenance, and staff.

## 🎾 Features

### Member Features
- **Court Booking**: Search and book available tennis courts by date
- **My Bookings**: View all your upcoming court bookings in an organized, card-based layout
- **Weather Forecast**: Real-time weather information for planning your games
- **Membership Options**: View different membership tiers and pricing

### Admin Features
- **Dashboard**: Centralized admin dashboard with quick access to key features
- **Booking Management**: View and manage all upcoming court bookings
- **Maintenance Scheduling**: Track court maintenance schedules and closures
- **Staff Management**: Add and manage staff members
- **Results Upload**: Upload and process match results via CSV files

## 🎨 Modern UI/UX Design

The application features a completely redesigned, modern user interface with:

- **Gradient Design**: Beautiful teal/turquoise color scheme throughout
- **Card-Based Layouts**: Clean, organized card components for better visual hierarchy
- **Responsive Design**: Fully responsive layout that works on all devices
- **Smooth Animations**: Hover effects and transitions for better user experience
- **Modern Typography**: Inter font family for clean, professional text
- **Icon Integration**: Emoji icons for visual enhancement and better UX
- **Accessible Forms**: Large, accessible form controls with helpful hints
- **Color-Coded Status**: Visual indicators for booking availability and court status

## 🛠️ Technology Stack

- **.NET 8.0**: Latest .NET framework
- **ASP.NET Core Razor Pages**: Server-side web framework
- **Entity Framework Core**: Data access and ORM
- **SQLite**: Database for development
- **Bootstrap 5**: Frontend CSS framework
- **jQuery**: JavaScript library for DOM manipulation
- **Identity Framework**: Authentication and authorization

## 📁 Project Structure

```
TennisBookings/
├── Areas/
│   ├── Admin/          # Admin area with MVC controllers and views
│   └── Identity/       # Identity pages for authentication
├── Pages/              # Razor Pages for member-facing features
├── Services/           # Business logic services
├── Data/               # Entity Framework data models
├── Configuration/      # Application configuration
├── BackgroundServices/ # Background processing services
├── wwwroot/            # Static files (CSS, JS, images)
└── Program.cs          # Application entry point
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or VS Code (recommended)
- Git

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

## 🔐 Authentication

The application uses ASP.NET Core Identity for authentication. Users can:
- Register new accounts
- Login with credentials
- Access role-based features (Member, Admin)

## 📋 Key Pages

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

## 🎯 Features in Detail

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

### Background Services
- Weather cache service for improved performance
- File processing service for async operations
- Database initialization service

## 🧪 Testing

To run tests (if available):
```bash
dotnet test
```

## 📝 Configuration

Application settings can be configured in:
- `appsettings.json` - General configuration
- `appsettings.Development.json` - Development-specific settings

Key configuration areas:
- Database connection strings
- External API endpoints
- Feature flags
- Booking rules and limits

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👤 Author

**Sizwe Mazibuko**
- Email: smazibuko@e4.co.za
- GitHub: [@GawdSizwe](https://github.com/GawdSizwe)

## 🙏 Acknowledgments

- Bootstrap team for the excellent CSS framework
- ASP.NET Core team for the robust web framework
- All contributors and users of this project

## 📞 Support

For support, email smazibuko@e4.co.za or create an issue in the repository.

---

**Built with ❤️ using ASP.NET Core and modern web technologies**

