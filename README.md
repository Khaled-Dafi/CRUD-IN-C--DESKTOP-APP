C# MySQL CRUD Desktop Application
This is a basic CRUD (Create, Read, Update, Delete) application implemented in C# using Windows Forms. The application interacts with a MySQL database managed by phpMyAdmin to perform various database operations on an employee record table.

Features
Create: Insert new employee records by providing details such as first name, middle initial, last name, gender, and position.

Read: Display all employee records in a DataGridView, allowing you to view the data stored in the database.

Update: Edit existing employee records by selecting a record, modifying the information, and clicking the Update button.

Delete: Delete employee records by selecting a record and clicking the Delete button.

Getting Started
Clone or download this repository to your local machine.

Open the solution in Visual Studio.

Make sure you have the MySQL Connector/NET package installed using NuGet Package Manager.

Update the connection string in the code to match your MySQL database configuration.

Build and run the application to see the CRUD operations in action.

How to Use
Add: Fill in the employee details in the input fields and click the Add button to insert a new employee record.

Update: Select an employee record from the DataGridView, modify the details in the input fields, and click the Update button to save the changes.

Read: Click the Show Data button to retrieve and display all employee records in the DataGridView.

Delete: Select an employee record from the DataGridView and click the Delete button to remove the record from the database.

Technologies Used
C# Windows Forms
MySQL Connector/NET
MySQL Database (Managed by phpMyAdmin)
Notes
Make sure to update the connection string with your MySQL server details in the code.
This is a basic example and may require additional features and error handling for production use.
