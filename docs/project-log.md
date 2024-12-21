# Project Log

## 2024/Dec/20
- **Current progress:** 
This step had a bit more working and more learnings, as such, I'll try to give a detailed report.
I've worked on the following: Classes, Postman/Swagger, MongoDb and Docker. It may seem too much for a single day, but those items are deeply connected.
### Classes
Finished all the backend classes up to a working point.
- Program.cs: In here I added the services to the container. I added a MongoDbSettings that holds our database settings, the UrlRepository that deals with the database and the UrlService that deals with the more specific logic. I'm also enabling the Swagger to test the endpoints.
- The Controller: it works very close to what I already did with MVC. I've set the actions to create and get the shortened links. I also left for the Services to deal with the actual logic behind the conversion of the link.
- The Services: it has the tasks to create and get the short link (this will access the repository class for the database related tasks). In here there is the logic behind the conversion.
- The Repository: In here I am doing database queries, adding and fetching from it. In here I also used the Database settings we've set at the Program.cs.
### Postman and Swagger
I've take the opportunity to learn how to use Postman and Swagger. Both are design to help developers test the endpoints of the application without the necessity of the frontend.
It was a bit of a challenge at the beginning, but once you get the configurations right, the process becomes very clear.
Both are working and with them I could also make sure my actions were working.
### MongoDB
There was no secret working with MongoDB. I've set the configuration at the `appsettings.json` and created a class to hold those configurations, the MongoDbSettings.
### Docker
Docker itself, once configured, is not hard. The problem lies on configuring it. For that I've had external help from my wife who already works with it.
We managed to make it work and the process itself is a bit more clear to me now. But I will definitely have to do it a few more times before I'm comfortable with it.

- **Next steps:** 
With a working backend I can move to the frontend.
- **Blockers:**
None.

## 2024/Dec/19
- **Current progress:** 
Installed all necessary NuGetPackages.
Created all the necessary folders



- **Next steps:** 
Based on the scope of the project, and with the first draft of the classes done, I decided to start by working on the backend.
- **Blockers:**
None.

## 2024/Dec/18
- **Current progress:** 
Created the GitHub directory.
Added the base of the front and backend.
Defined the scope of the project.
Decided which technologies are going to be used.
Added all the information into a documentation.
Uploaded the documentation and base of the project to GitHub.

Based on the requirements of the project, I design the first draft of the classes needed, as seen below:
<img alt="Classes Draft" src="./img/backend-first-draft.png" width=75%>

- **Next steps:** 
Based on the scope of the project, and with the first draft of the classes done, I decided to start by working on the backend.
- **Blockers:**
None.
