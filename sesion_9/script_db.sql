-- Database Script for an Inventory System in PostgreSQL

-- Table: Client
CREATE TABLE client (
    client_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    address TEXT,
    phone VARCHAR(15),
    email VARCHAR(100) UNIQUE
);

-- Table: Product
CREATE TABLE product (
    product_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    stock INTEGER NOT NULL DEFAULT 0
);

-- Table: Invoice
CREATE TABLE invoice (
    invoice_id SERIAL PRIMARY KEY,
    client_id INTEGER NOT NULL,
    date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10, 2) NOT NULL DEFAULT 0,
    FOREIGN KEY (client_id) REFERENCES client (client_id)
);

-- Table: InvoiceDetail
CREATE TABLE invoice_detail (
    detail_id SERIAL PRIMARY KEY,
    invoice_id INTEGER NOT NULL,
    product_id INTEGER NOT NULL,
    quantity INTEGER NOT NULL,
    unit_price DECIMAL(10, 2) NOT NULL,
    subtotal DECIMAL(10, 2),
    FOREIGN KEY (invoice_id) REFERENCES invoice (invoice_id),
    FOREIGN KEY (product_id) REFERENCES product (product_id)
);

-- Additional Indexes
CREATE INDEX idx_invoice_client_id ON invoice (client_id);
CREATE INDEX idx_invoice_detail_invoice_id ON invoice_detail (invoice_id);
CREATE INDEX idx_invoice_detail_product_id ON invoice_detail (product_id);


-- Sample Data Inserts for Client
INSERT INTO client (name, address, phone, email) VALUES
('John Doe', '123 Main St, Springfield', '555-1234', 'johndoe@example.com'),
('Jane Smith', '456 Elm St, Metropolis', '555-5678', 'janesmith@example.com'),
('Robert Brown', '789 Oak St, Gotham', '555-8765', 'robertbrown@example.com'),
('Emily Davis', '321 Pine St, Star City', '555-4321', 'emilydavis@example.com'),
('Michael Johnson', '654 Cedar St, Central City', '555-6789', 'michaeljohnson@example.com'),
('Sarah Wilson', '987 Maple St, Coast City', '555-9876', 'sarahwilson@example.com'),
('David Lee', '159 Spruce St, Bludhaven', '555-1590', 'davidlee@example.com'),
('Laura Martinez', '753 Birch St, Smallville', '555-7539', 'lauramartinez@example.com'),
('James White', '258 Ash St, Keystone', '555-2584', 'jameswhite@example.com'),
('Olivia Harris', '147 Redwood St, Ivy Town', '555-1476', 'oliviaharris@example.com'),
('William Clark', '369 Cypress St, Hub City', '555-3698', 'williamclark@example.com'),
('Sophia Lewis', '741 Fir St, Riverdale', '555-7412', 'sophialewis@example.com'),
('Benjamin Hall', '852 Cherry St, Harmony', '555-8526', 'benjaminhall@example.com'),
('Mia Young', '963 Willow St, Westview', '555-9637', 'miayoung@example.com'),
('Christopher King', '654 Magnolia St, Wakanda', '555-6541', 'christopherking@example.com'),
('Abigail Scott', '258 Sycamore St, Asgard', '555-2587', 'abigailscott@example.com'),
('Matthew Wright', '159 Palm St, Atlantis', '555-1598', 'matthewwright@example.com'),
('Charlotte Adams', '357 Poplar St, El Dorado', '555-3579', 'charlotteadams@example.com'),
('Daniel Hill', '741 Beech St, Emerald City', '555-7418', 'danielhill@example.com'),
('Amelia Baker', '963 Bamboo St, Arendelle', '555-9632', 'ameliabaker@example.com');

-- Sample Data Inserts for Product
INSERT INTO product (name, description, price, stock) VALUES
('Laptop', '14-inch display, 8GB RAM, 256GB SSD', 799.99, 50),
('Smartphone', '6.5-inch screen, 128GB storage, 5G capable', 599.99, 100),
('Tablet', '10-inch display, 64GB storage, WiFi', 299.99, 75),
('Headphones', 'Noise-cancelling, wireless', 199.99, 150),
('Keyboard', 'Mechanical, backlit', 89.99, 120),
('Mouse', 'Wireless, ergonomic', 49.99, 200),
('Monitor', '27-inch, 4K UHD', 349.99, 30),
('Printer', 'Multifunction, wireless', 149.99, 40),
('External Hard Drive', '1TB, USB 3.0', 79.99, 80),
('Flash Drive', '128GB, USB 3.1', 29.99, 250),
('Router', 'Dual-band, 1200Mbps', 89.99, 60),
('Webcam', '1080p resolution, USB', 49.99, 90),
('Smartwatch', 'Fitness tracking, notifications', 199.99, 70),
('Speaker', 'Bluetooth, portable', 99.99, 110),
('Charger', 'USB-C, fast charging', 19.99, 300),
('Power Bank', '10,000mAh, portable', 39.99, 180),
('Gaming Chair', 'Ergonomic, adjustable', 229.99, 25),
('Desk Lamp', 'LED, touch control', 29.99, 140),
('Microphone', 'Condenser, USB', 89.99, 55),
('SSD', '512GB, internal, SATA', 119.99, 45);

-- Sample Data Inserts for Invoice
INSERT INTO invoice (client_id, date, total) VALUES
(1, '2024-12-01 10:00:00', 1500.50),
(2, '2024-12-02 14:30:00', 875.75),
(3, '2024-12-03 16:45:00', 300.00),
(4, '2024-12-04 11:20:00', 450.25),
(5, '2024-12-05 09:15:00', 1200.00),
(6, '2024-12-06 15:40:00', 950.00),
(7, '2024-12-07 13:30:00', 560.90),
(8, '2024-12-08 17:10:00', 780.30),
(9, '2024-12-09 10:00:00', 200.00),
(10, '2024-12-10 14:00:00', 1100.00),
(11, '2024-12-11 16:00:00', 990.99),
(12, '2024-12-12 12:30:00', 340.00),
(13, '2024-12-13 11:45:00', 450.50),
(14, '2024-12-14 10:15:00', 780.00),
(15, '2024-12-15 14:45:00', 660.00),
(16, '2024-12-16 15:15:00', 870.00),
(17, '2024-12-17 09:30:00', 540.00),
(18, '2024-12-18 13:45:00', 300.00),
(19, '2024-12-19 10:45:00', 120.00),
(20, '2024-12-20 11:15:00', 220.00);

-- Sample Data Inserts for InvoiceDetail
INSERT INTO invoice_detail (invoice_id, product_id, quantity, unit_price) VALUES
(1, 1, 2, 799.99),
(1, 2, 1, 599.99),
(2, 3, 3, 299.99),
(2, 4, 2, 199.99),
(3, 5, 4, 89.99),
(3, 6, 5, 49.99),
(4, 7, 1, 349.99),
(4, 8, 1, 149.99),
(5, 9, 2, 79.99),
(5, 10, 3, 29.99),
(6, 11, 1, 89.99),
(6, 12, 2, 49.99),
(7, 13, 1, 199.99),
(7, 14, 3, 99.99),
(8, 15, 4, 19.99),
(8, 16, 5, 39.99),
(9, 17, 1, 229.99),
(9, 18, 2, 29.99),
(10, 19, 3, 89.99),
(10, 20, 1, 119.99);
