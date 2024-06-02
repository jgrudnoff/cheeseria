Welcome to the Cheeseria!

Project will run in containers, no need to setup additional dev environment, only docker is required. Applications are bound to the below ports/urls

Back end: https://localhost:8081/swagger/index.html
Front end: https://localhost:5180

Notes
- The front end styling is very basic, if more time was allowed it would look much more presentable, but I wanted to focus on the main functionality 
- This is actually my first attempt at using docker to containerize an application, there may be some rookie errors although I'm happy with the outcome overall. I hope this can demonstrate my ability to adapt and pickup new technologies as required.
- Backend uses SQLExpress, I would use sql server and plug in volumes to persist data for a deployed app
- Front end is single page, vue-router would be used for multi page apps. Pinia woould be used for an application any bigger than this to store the state and global variables
- The GlobalExceptionHandler class should handle the vast majority of logging and returning verbose error messages to the client. More specific in-line logs would be added for more isolated cases
