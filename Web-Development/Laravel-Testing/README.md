# Laravel Product Management Module

This is a Laravel 11 application with a product management module that provides full CRUD functionality, image upload, data validation, external API integration, and database operations.

## Features

- Full CRUD operations for products
- Image upload and management
- Data validation
- External API integration (dummyjson.com)
- Responsive UI using Bootstrap 5

## Installation

1. Clone the repository
2. Install dependencies:
   ```
   composer install
   npm install
   ```
3. Set up environment variables:
   ```
   cp .env.example .env
   php artisan key:generate
   ```
4. Run migrations:
   ```
   php artisan migrate
   ```
5. Create symbolic link for storage:
   ```
   php artisan storage:link
   ```
6. Start the development server:
   ```
   php artisan serve
   ```

## Usage

### Managing Products

1. **View Products**: Navigate to `/products` to see the list of all products
2. **Create Product**: Click "Create New Product" button to add a new product
3. **Edit Product**: Click "Edit" button on any product in the list
4. **View Product Details**: Click "View" button to see detailed information
5. **Delete Product**: Click "Delete" button with confirmation

### Product Fields

- **Name**: Required, unique string
- **Price**: Required, numeric value with minimum of 0
- **Description**: Optional text field
- **Image**: Optional file upload (JPEG, PNG, WebP, max 2MB)
- **External API Data**: Automatically fetched from dummyjson.com when creating a product

## API Integration

When creating a new product, the system automatically fetches data from the dummyjson API:
- GET request to: `https://dummyjson.com/products/{id}` (where id is a random number from 1-100)
- The 'title' field from the API response is stored in the 'external_api_data' column

## File Structure

```
app/
├── Http/Controllers/
│   └── ProductController.php
├── Models/
│   └── Product.php
database/
└── migrations/
    └── 2024_01_01_000000_create_products_table.php
resources/
└── views/
    ├── layouts/
    │   └── app.blade.php
    └── products/
        ├── index.blade.php
        ├── create.blade.php
        ├── edit.blade.php
        └── show.blade.php
routes/
└── web.php
```

## Database Schema

The `products` table contains the following columns:
- `id` (primary key)
- `name` (string, unique)
- `price` (decimal 10,2)
- `description` (text, nullable)
- `image_path` (string, nullable)
- `external_api_data` (text, nullable)
- `created_at`
- `updated_at`

## Contributing

Feel free to submit issues and enhancement requests.

## License

This project is open-sourced software licensed under the [MIT license](https://opensource.org/licenses/MIT).
