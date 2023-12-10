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

 **You will receive a response** like this:

 ```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQWRtaW4iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJVc2VyIiwiZXhwIjoxNzAyMjQ3MzM3LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQyMDAifQ.J9wYSvo9T_CgYl1qAwlmX1f2giny2bLwdALF36No75k",
  "expiration": "2023-12-10T22:28:57Z"
}
```

This token should be used for PUT, POST, and DELETE requests to the Books API at `https://localhost:5003/api/Books`.

Remember to include the token in the Authorization header of your requests to the Books API
