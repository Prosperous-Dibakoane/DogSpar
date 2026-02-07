# 🐕 Doggy Spar Booking System

A Windows Forms application for managing dog grooming service bookings. This system allows pet owners to book grooming appointments, select services, and helps business owners track sales and customer data.

## 📋 Features

### Customer Features
- **Service Selection**: Choose from 8 different grooming services
  - Bathing (R30)
  - Brushing and combing (R70)
  - Nail trimming (R80)
  - Ear cleaning (R30)
  - Blow drying (R30)
  - Fur styling (R90)
  - Tick and flea removal (R90)
  - Skin and coat assessment (R89)

- **Dog Size Categories**: Pricing based on dog size
  - Tiny (<4.5kg) - R100
  - Small (4.5kg - 11kg) - R120
  - Medium (>11kg - 25kg) - R130
  - Large (>25kg) - R140

- **Hair Type Selection**: Choose between short hair or long hair dogs
- **Appointment Scheduling**: Calendar-based date selection
- **Real-time Price Calculation**: Automatic total calculation based on selected services
- **Customer Information**: Save customer details (name, telephone, email, ID)

### Business Features
- **Data Extraction**: View all booking records in a data grid
- **Sales Reports**: Calculate total sales for custom date ranges
- **Specific Date Filtering**: View bookings for a particular date
- **Persistent Storage**: Customer bookings saved to text file

## 🛠️ Technology Stack

- **Language**: C#
- **Framework**: .NET Windows Forms
- **IDE**: Visual Studio 2022
- **Platform**: Windows Desktop Application

## 📁 Project Structure

```
DogGroomingServices/
├── Program.cs                  # Application entry point
├── Form1.cs                    # Main welcome screen
├── Form1.Designer.cs           # Main form UI components
├── Form2.cs                    # Service selection and booking
├── Form2.Designer.cs           # Booking form UI components
├── Form3.cs                    # Customer information form
├── Form3.Designer.cs           # Customer form UI components
├── Form4.cs                    # Data extraction and reports
├── Form4.Designer.cs           # Reports form UI components
├── AboutBox1.cs                # About dialog
├── AboutBox1.Designer.cs       # About dialog UI components
├── DogGroomingServices.user    # User configuration file
└── Resources/
    └── dog1.jpg                # Application logo/images
```

## 🚀 Getting Started

### Prerequisites
- Windows OS (Windows 10 or later recommended)
- .NET Framework 4.7.2 or higher
- Visual Studio 2022 (Community Edition or higher)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/doggy-parlour-booking-system.git
   cd doggy-parlour-booking-system
   ```

2. **Open the solution**
   - Open Visual Studio 2022
   - File → Open → Project/Solution
   - Select `DogGroomingServices.sln`

3. **Restore NuGet packages** (if needed)
   ```bash
   dotnet restore
   ```

4. **Build the project**
   - Build → Build Solution (Ctrl + Shift + B)

5. **Run the application**
   - Debug → Start Debugging (F5)
   - Or Debug → Start Without Debugging (Ctrl + F5)

## 📖 Usage Guide

### Making a Booking

1. **Launch Application**: Start from the welcome screen
2. **Navigate to Options**: Click `Options` in the menu bar
3. **Select Services**:
   - Choose your dog's size category
   - Select desired grooming services (multiple selections allowed)
   - Choose hair type from dropdown
   - Pick an appointment date from the calendar
4. **Review Total**: View calculated total in real-time
5. **Enter Customer Info**: Click "Next: Customer Info"
6. **Save Booking**: Fill in customer details and click "Save"

### Viewing Reports

1. **Access Data**: Click `Extract Data` in the menu bar
2. **View All Bookings**: Click "Extract Data" button to load all records
3. **Filter by Date Range**: Select from/to dates and click "Extract Data"
4. **View Specific Date**: Choose date and click "Show for Specific Date"
5. **Total Sales**: Automatically calculated and displayed

## 💾 Data Storage

Bookings are stored in `DogGroomingServices.user` file in the following format:
```
Name|Telephone|Email|ID|SelectedServices|Total|Date
```

## 🎨 User Interface

### Form1 - Welcome Screen
- Pink/coral background
- Dog logo display
- Menu bar with About, Options, and Extract Data

### Form2 - Service Selection
- Gray background
- Radio buttons for dog size selection
- Checklist for grooming services
- Dropdown for hair type
- Calendar for date selection
- Running total display

### Form3 - Customer Information
- Text fields for name, telephone, email, and ID
- Display of selected booking information
- Save button to confirm booking

### Form4 - Data Extraction
- Data grid view for all bookings
- Date range pickers
- Total sales calculation
- Filter options

## 🔧 Configuration

The application uses a custom user file (`DogGroomingServices.user`) for data persistence. This file is created automatically in the application directory upon first booking.

## 📝 License

Copyright © 2025 Pet Grooming Services Inc.  
Created by Prosperous Dibakoane (Student ID: 1234567)

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📧 Contact

**Developer**: Prosperous Dibakoane  
**Student ID**: 1234567

## 🐛 Known Issues

- Ensure `dog1.jpg` is added to project Resources
- Application requires write permissions to save booking data
- Data file path is relative to executable location

## 🔮 Future Enhancements

- [ ] Database integration (SQL Server)
- [ ] Email confirmation for bookings
- [ ] SMS reminders
- [ ] Online payment integration
- [ ] Multi-user support with authentication
- [ ] Export reports to PDF/Excel
- [ ] Appointment calendar view
- [ ] Customer history tracking
- [ ] Inventory management for grooming supplies

## 📊 Version History

- **v1.0** (2025) - Initial release
  - Basic booking functionality
  - Service selection
  - Customer data management
  - Sales reporting


![Demo Screenshot](dogspar.png)

---

**Made with ❤️ for pet lovers and grooming professionals**
