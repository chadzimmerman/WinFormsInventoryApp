# Inventory Management Application

## Overview
This project is a C# Windows Forms application developed as a solution for a small manufacturing organization seeking to modernize its inventory management. The application replaces a manual spreadsheet-based system with a more sophisticated and efficient inventory management tool. It was built using Visual Studio, following business requirements and solution statements designed by a system analyst.

## Features
- User-friendly GUI with clear navigation and controls
- CRUD (Create, Read, Update, Delete) operations for parts and products
- In-house and outsourced part management
- Product association with multiple parts
- Real-time search functionality
- Input validation to ensure data integrity
- Confirmation prompts before deletion

## User Interface
- Main Form: Add, Modify, Delete, Search buttons for parts and products; Exit button; lists and text boxes for parts and products.
- Add Part Form: Radio buttons for In-House and Outsourced parts, Save and Cancel buttons, text boxes for ID, name, inventory level, price, max, min, company name, or machine ID.
- Modify Part Form: Similar to Add Part Form, with fields pre-populated with existing part data.
- Add Product Form: Save, Cancel, Add Part, and Delete Part buttons; text boxes for ID, name, inventory level, price, max, and min values; search functionality.
- Modify Product Form: Similar to Add Product Form, with fields pre-populated with existing product data.

## Classes and Methods
The application is structured using object-oriented principles, following a UML class diagram provided by the system analyst. Key classes include:
- **Part Class:** Represents individual parts (In-House or Outsourced)
- **Product Class:** Represents products containing multiple parts
- **Inventory Class:** Manages the collection of parts and products

## Validation and Error Handling
- Prevents non-numeric input in numeric fields
- Ensures min values do not exceed max values and inventory is within bounds
- Disallows part deletion if associated with a product
- Prompts users to confirm deletions

## Technical Skills Demonstrated
- C# programming and OOP (Object-Oriented Programming)
- Windows Forms development using Visual Studio
- User input validation and error handling
- GUI design and event-driven programming
- Data manipulation and CRUD operations

## Why This Project Matters
This project demonstrates my ability to develop user-friendly applications that solve real-world business problems. By leveraging C# and Windows Forms, I created an application that improves efficiency and accuracy in managing inventory. This project highlights my skills in software design, development, and problem-solving.

## How to Run
1. Clone the repository.
2. Open the solution file in Visual Studio.
3. Build and run the project.

## Contact
If you have any questions or would like to discuss this project further, feel free to reach out!

