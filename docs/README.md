# Milestones

## 1. Understanding Requirements and Planning

Define the core features of the URL shortener:

- Shortening URLs
- Storing and retrieving links
- Managing different storage lifetimes for guest and registered users

Identify tools and technologies:
- Backend: ASP.NET Core REST API
- Frontend: React.js
- Database: MongoDB
- Hosting: Free-tier platforms (e.g., Azure App Services, Render, or Railway)

Research:
- URL generation techniques (GUIDs, hashes, or custom strings)
- Authentication approaches
- Rate-limiting strategies
- Set up GitHub repository and initial project structure for tracking progress.

## 2. Backend Development: ASP.NET Core API

Set up project structure:

- Create a new ASP.NET Core Web API project.
- Set up configuration for environment variables and database connection strings.

Create core classes:

- Url (Original URL, Shortened URL, Expiry Date, Access Count)
- User (for registered users, storing basic info)
- LinkManager (manages URL generation, storage, and retrieval logic)

Implement API endpoints:

- POST /api/links - Shorten a new URL (input: long URL, output: short URL)
- GET /api/links/{shortenedKey} - Retrieve the original URL
- GET /api/users/latest-links - Fetch latest links for logged-in users

Add business logic:

- URL shortening logic (hashing or custom string generation).
- Link expiration management.
- Validation for user inputs.

Set up error handling:

- Implement consistent error responses for invalid or expired links.
- Handle missing input or server errors gracefully.

Integration with database:

- Design and connect the database schema.
- Implement CRUD operations for links and users.

## 3. Frontend Development: React.js

Set up project structure:

- Create a React app.
- Configure routing for public (guest) and logged-in users.

UI Design:

- Minimal, responsive, and mobile-friendly design.
- Input form for submitting long URLs.
- Display the shortened link with copy-to-clipboard functionality.
- Display "latest links" for logged-in users.

Integrate with the API:

- Connect to backend endpoints using Axios or Fetch API.
- Show error messages for invalid URLs.

Features:

- Allow guest users to shorten links temporarily (e.g., stored for 5 days).
- Logged-in users can view and manage their 5 latest links.

Responsive UI:

- Ensure a clean and distraction-free interface for both desktop and mobile.

## 4. Database Design and Integration

MongoDB: Use collections with documents for links and user data.

Design schema:
- Urls: ID, OriginalURL, ShortenedKey, ExpiryDate, UserID (optional), AccessCount
- Users: ID, Username, PasswordHash

Implement database access logic in backend:

- Use Entity Framework Core (for MySQL) or MongoDB C# Driver.
- Ensure proper querying and indexing for performance.

## 5. Authentication and User Management

Implement basic user authentication:

- Register and login functionality.
- Use JWT (JSON Web Token) for secure API access.

Restrict features for guests vs. registered users:

- Guests: Shorten URLs with limited lifetime (e.g., 5 days).
- Registered users: Permanent storage and retrieval of their latest 5 links.

Secure user passwords:

- Hash and salt passwords using a library like BCrypt.

## 6. Deployment and Hosting

Choose a free hosting service:
- Azure App Services (backend and frontend)
- Railway or Render (alternative for small projects)?

Configure backend and frontend:

- Deploy the ASP.NET Core REST API.
- Deploy React frontend.

Use CI/CD (optional for learning):

- Set up GitHub Actions for automated deployment to Azure.

## 7. Enhancements and Bonus Features

Custom URL Generation:
- Allow users to choose a custom alias for their shortened URL (e.g., /mycustomlink)?

Rate Limiting:
- Prevent abuse by limiting the number of requests per user/guest.

Access Count:
- Track how many times each shortened link has been accessed.

Unit Testing:
- Write unit tests for key backend components and API endpoints.

Dockerization:
- Containerize the application using Docker.
- Practice deploying the application via Docker containers.

## 8. Testing and Debugging

Perform unit testing for:

- URL generation logic
- API endpoint behavior
- Authentication and database integration

Conduct end-to-end testing:

- Ensure the frontend and backend integrate seamlessly.
- Debug any errors:
- Address issues in API responses, database storage, or UI display.

## 9. Documentation and Cleanup

Write a README:
- Project overview and setup instructions.
- API documentation (endpoint descriptions, input/output examples).
- Technologies used and project goals.

Document the code:

- Add comments for classes, methods, and critical logic.

Clean up:

- Remove unused code or packages.
- Ensure consistent coding style.