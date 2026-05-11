# Order Processing System

## Project Description
This project is a simple Order Processing System using C# and Object-Oriented Programming.

The system can create customers, create products, create orders, add products to orders, calculate the total price, choose a payment method, and track order status.

## OOP Concepts Used

### Encapsulation
All classes use private data with public properties.

### Abstraction
The Payment class is abstract and hides payment details.

### Inheritance
ElectronicsProduct and ClothingProduct inherit from Product.

### Polymorphism
Different product types can calculate discounts differently.

### Interface
Interfaces such as IPayable and IShippable are used.

## Main Features
- Create Customer
- Create Products
- Create Order
- Add Products to Order
- Calculate Total Price
- Choose Payment Method
- Process Order
- Track Order Status

## Team Division

### Person 1
Customer and Product classes.

### Person 2
Order and OrderItem classes.

### Person 3
Payment classes and interfaces.

### Person 4
Main program, testing, GitHub merge, and README file.

## How to Run
1. Open the project in Visual Studio.
2. Build the project.
3. Run the project.
4. Test order creation and payment.
5. Check the final output.

## GitHub Workflow
Each team member worked on a separate branch.

Branches:
- customer-product-branch
- order-system-branch
- payment-system-branch
- main-testing-branch

Each branch was pushed to GitHub and merged into main using Pull Requests.

## Project Type
C# Application