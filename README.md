# UnitConversionCS

**UnitConversionCS** is a Razor-based web application that allows users to convert values between various units of measurement. It provides a simple and intuitive interface to perform unit conversions, making it a useful tool for students and professionals alike.

## Features

- **Unit Conversion**: Convert values between units such as Fahrenheit, Celsius, Kelvin, Rankine, Liters, and Cups.
- **Student Response Validation**: Validate user-provided responses against the correct converted value, with a tolerance for small rounding differences.
- **Test Coverage**: Comprehensive unit tests using xUnit to ensure the accuracy and reliability of the conversion logic.

## User Interface

The app's user interface consists of the following elements:

- **Input Value**: The value to be converted.
- **Input Unit**: The unit of the value to be converted (e.g., Fahrenheit, Celsius, etc.).
- **Target Unit**: The desired unit after conversion.
- **Student Response**: A field for users to input their expected conversion result.
- **Run Button**: Executes the conversion and checks the validity of the student response.

### Example UI:


Unit Conversion
Input Value: 0
Input Unit: Fahrenheit
Target Unit: Fahrenheit
Student Response:
RUN
```

## How It Works

1. Enter the value to be converted in the **Input Value** field.
2. Select the source unit from the **Input Unit** dropdown.
3. Select the target unit from the **Target Unit** dropdown.
4. Provide your expected conversion result in the **Student Response** field.
5. Click the **RUN** button to perform the conversion and validate your response.

## Running the Application

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/tromixx/UnitConversionCS.git
   cd UnitConversionCS
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to the provided URL (usually `http://localhost:5000` or similar).

### Running Tests

To ensure the application is working as expected, you can run the included unit tests:

```bash
dotnet test
```

## Code Overview

### Conversion Logic

The core of the application resides in the `ConversionService` class, which provides methods to:

- Convert values between units (`Convert` method).
- Validate user responses against the expected value with a tolerance (`ValidateResponse` method).

### Example Tests

The app includes unit tests to verify the accuracy of the conversion service. Examples include:

- Fahrenheit to Celsius: `32°F` → `0°C`
- Liters to Cups: `1 liter` → `4.22675 cups`

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests to improve the app.

---

- Check out the **UnitConversionCS API**: [UnitConversionAngular](https://github.com/tromixx/UnitConversionAngular) for a backend API implementation.
- Explore the **Angular-based UI** for the API: [UnitConversionAngularUI](https://github.com/tromixx/UnitConversionAngularUI).

