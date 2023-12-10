# LibraryAPI

# Project Instructions

This document provides instructions on how to interact with the Identity.API and use it for sending requests to the Books API.

## Step 1: Getting Started

**Open the solution** and **run Identity.API and Books.API**.


## Step 2: Send a POST Request

Once the Identity.API is running, you can authenticate by sending a POST request to the following URI: `https://localhost:5002/api/Authenticate/Login`.

The body of the request should be in JSON format, as shown below:

```json
{
  "username": "Admin",
  "password": "Admin"
}
```

## Step 3: Use the Token

After starting the Identity.API, you will receive a token. This token should be used for PUT, POST, and DELETE requests to the Books API at `https://localhost:5003/api/Books`.

Remember to include the token in the Authorization header of your requests to the Books API
