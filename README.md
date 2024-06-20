# Desktop Application for Submission Management
This desktop application allows users to create submissions including name, email, phone, GitHub link, and stopwatch time. It provides functionalities to submit data to a remote server and view previous submissions.

# Prerequisites
Before running the application, ensure you have the following installed:

# Visual Studio: 
Ensure you have Visual Studio installed to open and run the project.
Newtonsoft.Json Package: This project uses Newtonsoft.Json for JSON serialization. Make sure it's included in your project references. If not, you can install it via NuGet Package Manager:
bash
Copy code
Install-Package Newtonsoft.Json
Node.js and npm: Required to run the backend server locally.
Express and body-parser: These Node.js packages are used for the server-side implementation.
# Getting Started
Follow these steps to get the project up and running on your local machine:

Clone the Repository:
Copy code
git clone https://github.com/saipradeep29/DesktopApp.git
Open Solution in Visual Studio:

Navigate to the FormSubmissionApp directory.
Open 'FormSubmissionApp.sln' file in Visual Studio.

Install Dependencies:
Ensure Newtonsoft.Json package is installed in your project.
Set up Node.js server:
Copy code
cd server
npm install

Run the Application:
Start the Node.js server:
Copy code
npm start
Run the application from Visual Studio by pressing F5 or clicking on the "Start" button.
Usage:

Use the application to create submissions with name, email, phone, GitHub link, and stopwatch time.
Click "Submit" to send data to the server.
Use the "View Submissions" button to see previous submissions.

# Technologies Used
Frontend: Visual Basic .NET (VB.NET)
Backend: Node.js, Express.js
Database: In-memory (submissions stored in an array)
# working gudie 
below attached images shows how it looks 
main page
![Screenshot 2024-06-20 192418](https://github.com/saipradeep29/DesktopApp/assets/105792542/f476a9bd-3ebd-484d-ba3a-0514ab51f4cc)
view submissionform
![Screenshot 2024-06-20 192513](https://github.com/saipradeep29/DesktopApp/assets/105792542/37f74174-dae0-44fe-aa78-c0461391f305)
create submissionform
![Screenshot 2024-06-20 192558](https://github.com/saipradeep29/DesktopApp/assets/105792542/bd92a6c2-76f9-450d-8436-dfde0eaa849f)
![Screenshot 2024-06-20 192704](https://github.com/saipradeep29/DesktopApp/assets/105792542/298ffa3d-4a3d-486a-ac87-be7cc800fa94)



