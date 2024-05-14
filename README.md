
## Project Name:** Pizza Razor Pages Web App 🍕

**Description:**

This web application allows users to easily order their favorite pizzas online. It provides a user-friendly interface to browse the menu, customize their orders, and securely checkout. Additionally, it incorporates essential features like user registration, email verification, and order management.

**Key Features:**

- **Pizza Ordering:** Browse through a variety of pizza options, select sizes and toppings, and add them to the cart.
- **User Registration & Login:** Create an account, securely log in, and manage your personal information.
- **Email Verification:** Ensure users provide valid email addresses for communication and order confirmations.
- **Order Management:** Track your order status, view past orders, and modify existing orders.
- **Admin Dashboard (Optional):** If applicable, describe the admin panel for managing pizzas, orders, users, etc.

**Technologies Used:**

- **ASP.NET Core Razor Pages:** The core framework for building the web application's UI and logic.
- **Entity Framework Core:** ORM for interacting with the database and managing pizza, user, and order data.
- **Microsoft Identity:** Provides authentication and authorization features for user management.
- **Microsoft.EntityFrameworkCore.SqlServer:** Database provider for SQL Server.
- **Microsoft.AspNetCore.Authentication Libraries:** Integration with Facebook, Google, and Microsoft accounts for authentication.

## Installation Instructions:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Nef3rp1tou/RazorPagesTestAppMT.git
   ```

2. **Install dependencies:**
   ```bash
   dotnet restore
   ```

3. **Update `appsettings.json`:**
   - Configure your database connection string.
   - Set up email settings for verification emails.

4. **Apply migrations:**
   ```bash
   dotnet ef database update
   ```

5. **Run the application:**
   ```bash
   dotnet run
   ```
   Then open your web browser and navigate to `https://localhost:7154/` .

## Usage:

1. **Register/Login:**
   - Create a new account or log in with an existing one.
   - Verify your email address.
2. **Browse & Order:**
   - Explore the pizza menu.
   - Customize your pizza with toppings and sizes.
   - Add to cart and proceed to checkout.
3. **Track Orders:**
   - View your order history and current order status.


