# Geberit_WebHMI


## 🚀 About
This project was completed during my four-month internship at Geberit. My primary task was to implement a data collection protocol in the factory, enabling real-time access to sensor values. The solution was developed through multiple discussions with key stakeholders, including managers, floor managers, and operators, to ensure it met operational needs. Additionally, I designed and developed a database to store the collected data and built a web application with an interactive interface for real-time visualization. The application allows for efficient monitoring and analysis of factory sensor data, improving process transparency and decision-making.


## 🔍 How the Application Works
The application collects real-time sensor data and makes it accessible for visualization and analysis. The process follows these steps:
1. **Data Collection**: Sensor data is collected in real-time using **Softing** and **SAP Plant Connectivity**, which extract information from the factory's industrial equipment (Siemens PLC.
2. **Database Storage**: The extracted data is securely stored in a **Microsoft SQL Server** database, ensuring structured and efficient storage.
3. **Data Access via ASP.NET**: The web application, built with **ASP.NET MVC**, retrieves and displays data from the SQL Server in a read-only mode to ensure security and prevent unauthorized modifications.
4. **Visualization**: The front-end, developed with **HTML and visual components**, presents the real-time data in an interactive and user-friendly manner, allowing operators and stakeholders to monitor sensor values effectively.

## 🔍 Technologies Used

This project utilizes the following technologies:

- **CHTML** (for rendering dynamic web pages)
- **C#** (for backend development)
- **SQL** (for database management)
- **ASP.NET** (for web application framework)
- **MVC** (Model-View-Controller architecture for organizing the application)

## 📬 Contact
For any inquiries, reach out via [Email](youssefsidhom92@gmail.com) or create an issue in the repository.

