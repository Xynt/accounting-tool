# Basic functionality

- Create Account
- Add Record
  - Condition
    - At least two accounts required
  - Details
    - Debit & Credit
    - Amount
    - Description

## Screens

### Accounts

- List of all accounts
- Button to create account

### Records

- List of all records
- Button to create record

## API

### Create physical account

- /api/accounts/physical
- POST-Request
- params: name, amount

### Create virtual account

- /api/accounts/virtual
- POST-Request
- params: name

### Get accounts

- /api/accounts
- GET-Request

### Add Record

- /api/records
- POST-request
- params: debit, credit, amount, description

### Get Records

- /api/records
- GET-request