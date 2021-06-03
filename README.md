# Assignment2 - Patient Register

This is a patient registry for a hospital.

Users can run this app using a .exe file.

With this app a user can add new patients, update existing entries, designate a patient as dicharged, and view separate lists of long-term, day paitent, and discharged patients.

Users can search for patients using either name or patient ID with the “Search and Update” button.

Users can view and search a list of long-term patients by either name or patient ID using the “Long-Term Patients” button.

Users can view and search a list of day patients using the “Day Patients” button.

Users can discharge a patient by searching and selecting a patient and clicking "Discharge".

Users can create a new patient by clicking the "New Patient" button.

This opens new window where a user can enter the paient's details in fields.

Required fields are marked and must be filled, if they are not filled, an alert informs the user they must be filled.

New patients are given a unique ID based on system date and time.


Features
----------------------

This app uses a csv file as the database to store data. This file has some demo data pre-loaded. The patient data entered by the user during the app running is stored in this file.

The user can manually save the data while the application is running, by clicking the save icon.

When the user clicks the window “Close” button or “Exit” button on the main menu, the application will detect whether the user has changed or added patient data. If any patient data has been changed, the user is reminded to save any changes.

If the user just browsed patient data, without changing any data, the prompt does not appear.



Limitations
----------------------
The lists do not have sorting capability, users are expected to use the search function.

The app does not have an authentication function.

Patients cannot be searched by doctor, that is out of the scope for this app.
